using System;

class Bai13
{
    static void Main()
    {
        // Thiết lập mã hóa UTF-8 để hiển thị tiếng Việt trong console
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Khai báo số nguyên 1 byte không dấu
        byte n = NhapSoNguyen1Byte();

        // In ra màn hình giá trị được nhập
        Console.WriteLine("Giá trị được nhập: " + n);
    }

    // Hàm static đọc từ bàn phím số nguyên 1 byte không dấu, nằm trong khoảng 2 đến 10
    static byte NhapSoNguyen1Byte()
    {
        byte n;
        while (true)
        {
            Console.Write("Nhập số nguyên 1 byte không dấu (2-10): ");
            string input = Console.ReadLine();
            if (byte.TryParse(input, out n) && n >= 2 && n <= 10)
            {
                break;
            }
            Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
        }
        return n;
    }
}

