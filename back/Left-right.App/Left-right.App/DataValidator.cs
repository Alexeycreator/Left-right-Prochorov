namespace Left_right.App;

public static class DataValidator
{
    public static bool IsNonNegative(decimal value, string fieldName, out string error)
    {
        if (value < 0)
        {
            error = $"Поле «{fieldName}» не может быть отрицательным.";
            return false;
        }

        error = string.Empty;
        return true;
    }

    public static bool IsPositive(decimal value, string fieldName, out string error)
    {
        if (value <= 0)
        {
            error = $"Поле «{fieldName}» должно быть больше нуля.";
            return false;
        }

        error = string.Empty;
        return true;
    }

    public static bool ValidateWavelengths(decimal min, decimal max, decimal delta, out string error)
    {
        if (!IsPositive(min, "λ_min", out error))
            return false;
        if (!IsPositive(max, "λ_max", out error))
            return false;
        if (!IsPositive(delta, "Δλ", out error))
            return false;

        if (min >= max)
        {
            error = "λ_min должно быть меньше λ_max.";
            return false;
        }

        decimal points = (max - min) / delta + 1;
        if (points > AppConfig.MaxGridPoints)
        {
            error = $"Слишком много точек сетки ({points:0}). Увеличьте Δλ или уменьшите диапазон.";
            return false;
        }

        error = string.Empty;
        return true;
    }

    public static bool ValidateTaskAndBands(int taskIndex, int bandCount, out string error)
    {
        if (taskIndex < 0)
        {
            error = "Не выбран тип задачи.";
            return false;
        }

        if (bandCount == 0)
        {
            error = "Добавьте хотя бы одну модельную полосу в таблицу.";
            return false;
        }

        error = string.Empty;
        return true;
    }

    public static bool ValidateOutput(bool wantJson, bool wantPng, out string error)
    {
        if (!wantJson && !wantPng)
        {
            error = "Выберите хотя бы один формат вывода (JSON или PNG).";
            return false;
        }

        error = string.Empty;
        return true;
    }

    public static bool ValidateEnvironment(bool isRightChecked, bool isLeftChecked, out string error)
    {
        if (!isRightChecked && !isLeftChecked)
        {
            error = "Выберите тип среды: правая или левая.";
            return false;
        }

        error = string.Empty;
        return true;
    }

    public static bool ValidateComboBox(int selectedIndex, string fieldName, out string error)
    {
        if (selectedIndex < 0)
        {
            error = $"Не выбрано значение в поле «{fieldName}».";
            return false;
        }

        error = string.Empty;
        return true;
    }

    public static bool ValidateAll(
        int taskIndex,
        int bandCount,
        decimal lambdaMin,
        decimal lambdaMax,
        decimal lambdaDelta,
        decimal thickness,
        decimal concentration,
        decimal pathLength,
        decimal molarMass,
        bool isRightEnvironment,
        bool isLeftEnvironment,
        int concUnitsIndex,
        int stripTypeIndex,
        int outputUnitsIndex,
        bool wantJson,
        bool wantPng,
        out string error)
    {
        if (!ValidateTaskAndBands(taskIndex, bandCount, out error))
            return false;
        if (!ValidateWavelengths(lambdaMin, lambdaMax, lambdaDelta, out error))
            return false;
        if (!IsNonNegative(thickness, "Толщина", out error))
            return false;
        if (!IsPositive(concentration, "Концентрация", out error))
            return false;
        if (!IsPositive(pathLength, "Длина пути", out error))
            return false;
        if (!IsNonNegative(molarMass, "Молярная масса", out error))
            return false;
        if (!ValidateEnvironment(isRightEnvironment, isLeftEnvironment, out error))
            return false;
        if (!ValidateComboBox(concUnitsIndex, "Единицы концентрации", out error))
            return false;
        if (!ValidateComboBox(stripTypeIndex, "Тип полос", out error))
            return false;
        if (!ValidateComboBox(outputUnitsIndex, "Единицы вывода", out error))
            return false;
        if (!ValidateOutput(wantJson, wantPng, out error))
            return false;

        error = string.Empty;
        return true;
    }
}