using System;

public struct Student
{
    public string Name;
    public double Score;
}

public class Bai10
{
    public static void Main()
    {
        Console.Write("Nhập số lượng sinh viên: ");
        int n = int.Parse(Console.ReadLine());

        Student[] students = new Student[n];

        // Nhập thông tin sinh viên
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin sinh viên {i + 1}:");
            Console.Write("Tên: ");
            students[i].Name = Console.ReadLine();
            Console.Write("Điểm: ");
            students[i].Score = double.Parse(Console.ReadLine());
        }

        // Hiển thị thông tin sinh viên
        Console.WriteLine("\nThông tin sinh viên:");
        double totalScore = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Tên: {students[i].Name}, Điểm: {students[i].Score}");
            totalScore += students[i].Score;
        }

        // Tính điểm trung bình
        double averageScore = totalScore / n;
        Console.WriteLine($"\nĐiểm trung bình của lớp: {averageScore:F2}");
    }
}
