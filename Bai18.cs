using System;

class Program
{
    // a. Viết hàm static đọc vào số thực 8 byte. Nhập sai thì nhập lại.
    static double ReadDouble()
    {
        double value;
        while (true)
        {
            Console.Write("Nhap so thuc 8 byte: ");
            if (double.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            Console.WriteLine("Gia tri nhap khong hop le. Vui long nhap lai.");
        }
    }

    // b. Trong lớp chứa hàm Main() khai báo biến số thực 8 byte x. Gọi hàm để đọc vào số x. Hiển thị giá trị căn bậc 2 của x.
    static void Main()
    {
        double x = ReadDouble();
        Console.WriteLine($"Gia tri can bac 2 cua {x} la: {Math.Sqrt(x)}");
    }
}