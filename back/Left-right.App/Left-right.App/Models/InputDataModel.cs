using System.Text.Json.Serialization;

namespace Left_right.App.Models;

public class InputDataModel
{
    [JsonPropertyName("task")] public string Task { get; set; } = string.Empty;

    [JsonPropertyName("experiment")] public ExperimentData Experiment { get; set; } = new();

    [JsonPropertyName("medium_model")] public MediumModelData MediumModel { get; set; } = new();

    [JsonPropertyName("output")] public OutputData Output { get; set; } = new();

    // Новые поля: готовые массивы точек для графиков
    [JsonPropertyName("results")] public ResultsData Results { get; set; } = new();
}

public class ExperimentData
{
    [JsonPropertyName("wavelength_min")] public decimal WavelengthMin { get; set; }

    [JsonPropertyName("wavelength_max")] public decimal WavelengthMax { get; set; }

    [JsonPropertyName("wavelength_step")] public decimal WavelengthStep { get; set; }

    [JsonPropertyName("thickness_mm")] public decimal ThicknessMm { get; set; }

    [JsonPropertyName("concentration")] public decimal Concentration { get; set; }

    [JsonPropertyName("concentration_units")]
    public string ConcentrationUnits { get; set; } = string.Empty;

    [JsonPropertyName("path_length")] public decimal PathLength { get; set; }

    [JsonPropertyName("molar_mass")] public decimal MolarMass { get; set; }
}

public class MediumModelData
{
    [JsonPropertyName("sign")] public int Sign { get; set; }

    [JsonPropertyName("model_type")] public string ModelType { get; set; } = string.Empty;

    [JsonPropertyName("bands")] public List<BandData> Bands { get; set; } = new();
}

public class BandData
{
    [JsonPropertyName("center")] public decimal Center { get; set; }

    [JsonPropertyName("width")] public decimal Width { get; set; }

    [JsonPropertyName("amplitude")] public decimal Amplitude { get; set; }
}

public class OutputData
{
    [JsonPropertyName("want_json")] public bool WantJson { get; set; }

    [JsonPropertyName("want_png")] public bool WantPng { get; set; }

    [JsonPropertyName("units")] public string Units { get; set; } = string.Empty;
}

// --- Классы для готовых данных ---

public class ResultsData
{
    [JsonPropertyName("wavelength")] public List<double> Wavelength { get; set; } = new();

    [JsonPropertyName("delta_epsilon")] public List<double> DeltaEpsilon { get; set; } = new();

    [JsonPropertyName("delta_a")] public List<double> DeltaA { get; set; } = new();

    [JsonPropertyName("ellipticity")] public List<double> Ellipticity { get; set; } = new();

    [JsonPropertyName("optical_rotation")] public List<double> OpticalRotation { get; set; } = new();

    // Для 3D графиков (например, зависимость от концентрации)
    [JsonPropertyName("surface_3d")] public Surface3DData Surface3D { get; set; } = new();
}

public class Surface3DData
{
    [JsonPropertyName("x_wavelength")] public List<double> XWavelength { get; set; } = new();

    [JsonPropertyName("y_concentration")] public List<double> YConcentration { get; set; } = new();

    [JsonPropertyName("z_ellipticity")] public List<List<double>> ZEllipticity { get; set; } = new();
}