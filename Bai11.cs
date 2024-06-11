using System;
using System.IO;

public class Bai11
{
    public static void Main()
    {
        Console.Write("Nhập tên file: ");
        string fileName = Console.ReadLine();

        Console.Write("Nhập nội dung file: ");
        string content = Console.ReadLine();

        // Ghi nội dung vào file
        WriteToFile(fileName, content);

        // Đọc nội dung từ file
        string readContent = ReadFromFile(fileName);

        Console.WriteLine($"Nội dung file '{fileName}': {readContent}");
    }

    public static void WriteToFile(string fileName, string content)
    {
        try
        {
            File.WriteAllText(fileName, content);
            Console.WriteLine("Đã ghi nội dung vào file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi ghi file: {ex.Message}");
        }
    }

    public static string ReadFromFile(string fileName)
    {
        try
        {
            return File.ReadAllText(fileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
            return string.Empty;
        }
    }
}
