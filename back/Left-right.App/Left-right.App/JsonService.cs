using System.Text.Json;
using Left_right.App.Models;

namespace Left_right.App;

public static class JsonService
{
    private static readonly JsonSerializerOptions Options = new() { WriteIndented = true };

    public static string SaveInput(InputDataModel data, string folderPath)
    {
        try
        {
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            string json = JsonSerializer.Serialize(data, Options);
            string path = Path.Combine(folderPath, AppConfig.InputFileName);
            File.WriteAllText(path, json);
            return path;
        }
        catch (UnauthorizedAccessException ex)
        {
            throw new IOException($"Нет прав на запись в папку «{folderPath}».", ex);
        }
        catch (JsonException ex)
        {
            throw new InvalidOperationException("Ошибка сериализации объекта в JSON.", ex);
        }
        catch (Exception ex)
        {
            throw new IOException("Не удалось сохранить input.json.", ex);
        }
    }
}