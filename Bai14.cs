using System;
using System.Text;

class Bai14
{
    static void Main(string[] args)
    {
        // Đảm bảo hiển thị tiếng Việt trong console
        Console.OutputEncoding = Encoding.UTF8;
        float x;
        x = GetFloat();
        Console.WriteLine($"Gia tri x da nhap: {x}");
    }
    /// Hàm static đọc từ bàn phím 1 giá trị số thực 4 byte, nếu nhập sai thì nhập lại.
    /// <returns>Số thực 4 byte</returns>
    static float GetFloat()
    {
        float value;
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out value))
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