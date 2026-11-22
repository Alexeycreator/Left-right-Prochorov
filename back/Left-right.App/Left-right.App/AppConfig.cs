namespace Left_right.App;

public static class AppConfig
{
    // Коэффициент перевода из ΔA в эллиптичность (мград)
    public const double EllipticityCoefficient = 32980.0;

    // Максимально допустимое количество точек сетки
    public const int MaxGridPoints = 100000;

    // Папка и имя файла обмена
    public const string ExchangeFolderName = "Data";
    public const string InputFileName = "input.json";

    public static string ExchangeFolderPath =>
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ExchangeFolderName);

    public static string InputFilePath =>
        Path.Combine(ExchangeFolderPath, InputFileName);

    // Текст для правой панели с формулами
    public const string FormulasText =
        "1. Оптическое вращение (ORD):\n" +
        "φ(λ) = (π·d/λ)·Δn(λ)\n" +
        "φ_град = (180·d/λ)·Δn\n\n" +
        "2. Удельное и молярное вращение:\n" +
        "[α] = φ_град / (c·l)\n" +
        "[Φ] = [α]·M / 100\n\n" +
        "3. Круговой дихроизм (CD):\n" +
        "ΔA = Δε·c·l\n" +
        "θ_мград = 32980·ΔA\n" +
        "[θ] = θ_мград / (c·l) = 32980·Δε\n\n" +
        "4. Модельные полосы:\n" +
        "Гаусс: Δε(λ) = Σ A_k·exp(−(λ−λ_k)²/(2σ_k²))\n" +
        "FWHM = 2.355·σ_k\n" +
        "Лоренц: Δε(λ) = Σ A_k·γ_k²/((λ−λ_k)²+γ_k²)\n\n" +
        "5. Крамерс — Кронига (CD → ORD):\n" +
        "φ(λ_i) ≈ (2/π)·Σ_{j≠i} λ_j·Δε(λ_j)/(λ_j²−λ_i²)·Δλ\n\n" +
        "Единицы:\n" +
        "λ — нм, d — мм, c — моль/л, l — см\n" +
        "A_k — л·моль⁻¹·см⁻¹, θ — мград";
}