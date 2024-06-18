using System;
using System.Text;

class Bai12
{
    static void Main(string[] args)
    {
        // Đảm bảo hiển thị tiếng Việt trong console
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo số nguyên n 2 byte không dấu
        ushort n;

        // Gọi hàm để nhập giá trị của n
        n = GetUShort();
        Console.WriteLine($"Gia tri n da nhap: {n}");

        // Tính tổng bình phương các số từ 1 đến n
        ulong sum = 0;
        for (ushort i = 1; i <= n; i++)
        {
            sum += (ulong)i * i;
        }
        Console.WriteLine($"Tong binh phuong cac so tu 1 den {n} la: {sum}");
    }

    /// Hàm static đọc từ bàn phím số nguyên 2 byte không dấu, nếu nhập sai thì nhập lại.
    /// <returns>Số nguyên 2 byte không dấu</returns>
    static ushort GetUShort()
    {
        ushort value;
        while (true)
        {
            if (ushort.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Nhap sai, vui long nhap lai!");
            }
        }
    }
}