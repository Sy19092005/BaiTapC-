using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Đảm bảo hiển thị tiếng Việt trong console
        Console.OutputEncoding = Encoding.UTF8;
        byte m, n;
        m = GetByte(2, 10);
        n = GetByte(2, 10);
        Console.WriteLine($"Gia tri m = {m}, n = {n}");

        int[,] a = new int[m, n];

        // Gọi hàm để nhập giá trị các phần tử của mảng a từ bàn phím
        FillArray2D(a);

        // In ra màn hình giá trị được nhập của mảng a
        PrintArray2D(a);

        // Gọi hàm để tính tổng các phần tử của mảng chia hết cho 2024
        int sum = SumDivisibleBy2024(a);
        Console.WriteLine($"Tong cac phan tu chia het cho 2024: {sum}");
    }

    /// <summary>
    /// Hàm static đọc từ bàn phím số nguyên 1 byte, không dấu, nằm trong khoảng min đến max, nếu nhập sai thì nhập lại.
    /// </summary>
    /// <param name="min">Giá trị tối thiểu</param>
    /// <param name="max">Giá trị tối đa</param>
    /// <returns>Số nguyên 1 byte nằm trong khoảng min đến max</returns>
    static byte GetByte(int min, int max)
    {
        byte value;
        while (true)
        {
            if (byte.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
            {
                return value;
            }
            else
            {
                Console.WriteLine($"Nhap sai, vui long nhap so nguyen tu {min} den {max}!");
            }
        }
    }

    /// <summary>
    /// Hàm static đọc từ bàn phím 1 giá trị số nguyên 4 byte, nếu nhập sai thì nhập lại.
    /// </summary>
    /// <returns>Số nguyên 4 byte</returns>
    static int GetInt()
    {
        int value;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Nhap sai, vui long nhap lai!");
            }
        }
    }

    /// <summary>
    /// Hàm nhập vào 1 mảng 2 chiều các số nguyên 4 byte.
    /// </summary>
    /// <param name="arr">Mảng 2 chiều số nguyên 4 byte</param>
    static void FillArray2D(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"Nhap phan tu [{i},{j}]: ");
                arr[i, j] = GetInt();
            }
        }
    }

    /// <summary>
    /// Hàm in ra màn hình một mảng 2 chiều số nguyên 4 byte.
    /// </summary>
    /// <param name="arr">Mảng 2 chiều số nguyên 4 byte</param>
    static void PrintArray2D(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Hàm tính tổng các phần tử chia hết cho 2024 của mảng 2 chiều.
    /// </summary>
    /// <param name="arr">Mảng 2 chiều số nguyên 4 byte</param>
    /// <returns>Tổng các phần tử chia hết cho 2024</returns>
    static int SumDivisibleBy2024(int[,] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] % 2024 == 0)
                {
                    sum += arr[i, j];
                }
            }
        }
        return sum;
    }
}   