using System.Globalization;

string inputFilePath, outputFilePath;

do
{
    Console.WriteLine("Введите путь к входному файлу логов:");
    inputFilePath = Console.ReadLine();
} while (inputFilePath.Length < 3);

do
{
    Console.WriteLine("Введите путь к выходному файлу:");
    outputFilePath = Console.ReadLine();
} while (outputFilePath.Length < 3);

// Файл с ошибками по тому же пути, что и выходной
string problemsFilePath = Path.Combine(Path.GetDirectoryName(outputFilePath), "problems.txt");

try
{
    List<string> standardizedLogs = new List<string>();
    List<string> invalidLogs = new List<string>();

    // Обработка строк входного файла
    foreach (string line in File.ReadLines(inputFilePath))
    {
        string standardizedLog = ProcessLogLine(line);
        if (standardizedLog != null)
        {
            standardizedLogs.Add(standardizedLog);
        }
        else
        {
            invalidLogs.Add(line);
        }
    }

    if (invalidLogs.Count > 0)
    {
        File.WriteAllLines(problemsFilePath, invalidLogs);
        Console.WriteLine($"Невалидные записи найдены и сохранены в файл: {problemsFilePath}");
    }

    // Дозапись в существующий выходной файл
    using (StreamWriter writer = new(outputFilePath, append: true))
    {
        foreach (var log in standardizedLogs)
        {
            writer.WriteLine(log);
        }
    }
    // File.WriteAllLines(outputFilePath, standardizedLogs); //Раскомментить если нужно перезаписывать выходной файл
    Console.WriteLine("Обработка завершена. Стандартизированные данные записаны в выходной файл.");

}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

static string ProcessLogLine(string line)
{
    try
    {
        if (line.Contains("INFORMATION") || line.Contains("WARNING"))
        {
            // Обработка Формата 1
            string[] parts = line.Split(new[] { ' ' }, 4);
            string date = DateTime.ParseExact(parts[0], "dd.MM.yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            string time = parts[1];
            string level = parts[2] == "INFORMATION" ? "INFO" : "WARN";
            string message = parts[3];

            return $"{date}\t{time}\t{level}\tDEFAULT\t{message}";
        }
        else if (line.Contains("|"))
        {
            // Обработка Формата 2
            string[] parts = line.Split('|');
            string[] dateTime = parts[0].Trim().Split(' ');
            string date = DateTime.ParseExact(dateTime[0], "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            string time = dateTime[1];
            string level = parts[1].Trim() == "INFO" ? "INFO" : parts[1].Trim() == "WARN" ? "WARN" : parts[1].Trim();
            string method = parts.Length > 3 ? parts[3].Trim() : "DEFAULT";
            string message = parts.Length > 4 ? parts[4].Trim() : "";

            return $"{date}\t{time}\t{level}\t{method}\t{message}";
        }
        else
        {
            // Невалидная строка
            return null;
        }
    }
    catch
    {
        // Любая ошибка приводит к маркировке строки как невалидной
        return null;
    }
}