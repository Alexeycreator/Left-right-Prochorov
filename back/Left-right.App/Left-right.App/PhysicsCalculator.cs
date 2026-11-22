using System;
using System.Collections.Generic;
using System.Linq;
using Left_right.App.Models;

namespace Left_right.App;

public class PhysicsCalculator
{
    private const double EllipticityCoefficient = AppConfig.EllipticityCoefficient;
    private const int MaxPointsLimit = 10000; // Защита от зависания UI

    public double CalculateEllipticity(double deltaA) => EllipticityCoefficient * deltaA;

    public double CalculateSpecificRotation(double phiDegrees, double concentration, double pathLength)
    {
        if (concentration <= 0 || pathLength <= 0)
            throw new ArgumentException("Концентрация и длина пути должны быть строго больше нуля.");
        return phiDegrees / (concentration * pathLength);
    }

    public double CalculateMolarRotation(double specificRotation, double molarMass)
    {
        if (molarMass < 0) throw new ArgumentException("Молярная масса не может быть отрицательной.");
        return specificRotation * molarMass / 100.0;
    }

    public double CalculateDeltaA(double deltaEpsilon, double concentration, double pathLength)
    {
        return deltaEpsilon * concentration * pathLength;
    }

    public double CalculateFwhm(double sigma)
    {
        if (sigma <= 0) throw new ArgumentException("Ширина σ должна быть больше нуля.");
        return 2.0 * Math.Sqrt(2.0 * Math.Log(2.0)) * sigma;
    }

    public double CalculateGaussianBand(double lambda, double center, double sigma, double amplitude)
    {
        if (sigma <= 0) throw new ArgumentException("Ширина σ гауссовой полосы должна быть больше нуля.");
        double diff = lambda - center;
        double exponent = -(diff * diff) / (2.0 * sigma * sigma);
        return amplitude * Math.Exp(exponent);
    }

    public double CalculateLorentzBand(double lambda, double center, double gamma, double amplitude)
    {
        if (gamma <= 0) throw new ArgumentException("Ширина γ лоренцевой полосы должна быть больше нуля.");
        double diff = lambda - center;
        return amplitude * (gamma * gamma) / (diff * diff + gamma * gamma);
    }

    public double CalculateKramersKronig(double targetLambda, double[] gridLambdas, double[] deltaEpsilons,
        double deltaLambda)
    {
        if (gridLambdas.Length != deltaEpsilons.Length)
            throw new ArgumentException("Массивы длин волн и значений Δε должны быть одинаковой длины.");

        double sum = 0;
        for (int j = 0; j < gridLambdas.Length; j++)
        {
            double lambdaJ = gridLambdas[j];
            if (Math.Abs(lambdaJ - targetLambda) < 1e-10) continue;
            sum += (lambdaJ * deltaEpsilons[j]) / (lambdaJ * lambdaJ - targetLambda * targetLambda);
        }

        return (2.0 / Math.PI) * sum * deltaLambda;
    }

    // --- ГЛАВНЫЙ МЕТОД ДЛЯ ГЕНЕРАЦИИ ВСЕХ ТОЧЕК ---
    public ResultsData CalculateFullSpectrum(InputDataModel input)
    {
        var results = new ResultsData();

        decimal minDec = input.Experiment.WavelengthMin;
        decimal maxDec = input.Experiment.WavelengthMax;
        decimal stepDec = input.Experiment.WavelengthStep;

        if (stepDec <= 0) throw new ArgumentException("Шаг сетки должен быть больше нуля.");
        if (minDec >= maxDec) throw new ArgumentException("Максимум должен быть больше минимума.");

        double conc = (double)input.Experiment.Concentration;
        double path = (double)input.Experiment.PathLength;

        // Вычисляем точное количество точек с помощью decimal
        int pointCount = (int)Math.Floor((double)((maxDec - minDec) / stepDec)) + 1;

        if (pointCount > MaxPointsLimit)
            throw new ArgumentException(
                $"Слишком много точек ({pointCount}). Увеличьте шаг Δλ или уменьшите диапазон (лимит {MaxPointsLimit}).");

        var lambdas = new List<double>(pointCount);
        for (int i = 0; i < pointCount; i++)
        {
            decimal currentL = minDec + i * stepDec;
            if (currentL > maxDec) break;
            lambdas.Add((double)currentL);
        }

        results.Wavelength = lambdas;

        // Считаем Δε
        var deltaEpsilons = new List<double>(lambdas.Count);
        foreach (var lambda in lambdas)
        {
            double totalDe = 0;
            foreach (var band in input.MediumModel.Bands)
            {
                double center = (double)band.Center;
                double width = (double)band.Width;
                double amp = (double)band.Amplitude;

                if (input.MediumModel.ModelType == "gaussian_bands")
                    totalDe += CalculateGaussianBand(lambda, center, width, amp);
                else
                    totalDe += CalculateLorentzBand(lambda, center, width, amp);
            }

            deltaEpsilons.Add(totalDe * input.MediumModel.Sign);
        }

        results.DeltaEpsilon = deltaEpsilons;

        // Считаем ΔA и θ
        var deltaAs = new List<double>(lambdas.Count);
        var thetas = new List<double>(lambdas.Count);
        foreach (var de in deltaEpsilons)
        {
            double dA = CalculateDeltaA(de, conc, path);
            deltaAs.Add(dA);
            thetas.Add(CalculateEllipticity(dA));
        }

        results.DeltaA = deltaAs;
        results.Ellipticity = thetas;

        // Считаем ORD
        var ord = new List<double>(lambdas.Count);
        var lambdaArray = lambdas.ToArray();
        var deArray = deltaEpsilons.ToArray();
        double deltaLambda = (double)stepDec;

        foreach (var l in lambdas)
        {
            double phiRad = CalculateKramersKronig(l, lambdaArray, deArray, deltaLambda);
            double phiDeg = phiRad * (180.0 / Math.PI);
            ord.Add(phiDeg);
        }

        results.OpticalRotation = ord;

        // 3D-данные
        var concentrations = new List<double> { conc * 0.5, conc, conc * 1.5 };
        var zMatrix = new List<List<double>>();
        foreach (var c in concentrations)
        {
            var row = new List<double>(lambdas.Count);
            foreach (var de in deltaEpsilons)
            {
                double dA = CalculateDeltaA(de, c, path);
                row.Add(CalculateEllipticity(dA));
            }

            zMatrix.Add(row);
        }

        results.Surface3D = new Surface3DData
        {
            XWavelength = lambdas,
            YConcentration = concentrations,
            ZEllipticity = zMatrix
        };

        return results;
    }
}