using System;
using System.Collections.Generic;
using System.Text;

public class Bai8
{
    public static void Main()
    {
        // a. Chương trình hiển thị bảng mã ASCII
        Console.WriteLine("Bảng mã ASCII:");
        Console.WriteLine("------------------");
        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine($"{i} - {(char)i}");
        }
        Console.WriteLine();

        // b. Chương trình hiển thị bảng mã UTF-8 của trang mã 65001
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Bảng mã UTF-8 (trang mã 65001):");
        Console.WriteLine("------------------");
        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine($"{i} - {(char)i}");
        }
        Console.WriteLine();

        // c. Chương trình phát tiếng beep khi nhấn phím space
        Console.WriteLine("Nhấn phím space để phát tiếng beep. Nhấn Ctrl+C để thoát.");
        while (true)
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                Console.Beep();
            }
        }

        // d. Chương trình đếm số lần xuất hiện của các ký tự trong chuỗi do người dùng nhập
        Console.Write("Nhập vào một chuỗi ký tự: ");
        string input = Console.ReadLine();
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }
        Console.WriteLine("Kết quả đếm:");
        foreach (KeyValuePair<char, int> kvp in charCount)
        {
            Console.WriteLine($"Ký tự '{kvp.Key}' xuất hiện {kvp.Value} lần.");
        }
    }
}
