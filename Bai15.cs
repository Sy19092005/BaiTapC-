using System;

class Bai15
{
    static void Main()
    {
        // Thiết lập mã hóa UTF-8 để hiển thị tiếng Việt trong console
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Khai báo số nguyên 1 byte không dấu và nhập giá trị
        byte n = NhapSoNguyen1Byte();
        Console.WriteLine("Giá trị được nhập: " + n);

        // Khai báo mảng 1 chiều các số thực 4 byte a và cấp phát để a gồm n phần tử
        float[] a = new float[n];

        // Nhập giá trị các phần tử của mảng a từ bàn phím
        NhapMangSoThuc(a);

        // In ra màn hình giá trị được nhập của mảng a
        Console.WriteLine("Các phần tử của mảng a:");
        foreach (var item in a)
        {
            Console.WriteLine(item);
        }
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

    // Hàm static đọc từ bàn phím 1 giá trị số thực 4 byte
    static float NhapSoThuc4Byte()
    {
        float value;
        while (true)
        {
            Console.Write("Nhập giá trị số thực 4 byte: ");
            string input = Console.ReadLine();
            if (float.TryParse(input, out value))
            {
                break;
            }
            Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
        }
        return value;
    }

    // Hàm nhập vào 1 mảng số thực 4 byte với số phần tử là n
    static void NhapMangSoThuc(float[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write($"Nhập giá trị cho phần tử thứ {i + 1}: ");
            a[i] = NhapSoThuc4Byte();
        }
    }
}

