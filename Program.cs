using System;

namespace NumberOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bài 1a: Sử dụng C# nhập từ bàn phím 2 số nguyên a và b kiểu 4 byte, có sử dụng điều khiển exception để nếu nhập sai thì nhập lại. Sau đó in ra màn hình tổng, hiệu, tích và thương (số nguyên), thương số thực của a và b và chương trình chạy ở mode Console.
            int a, b;

            // Nhập a và b, sử dụng try-catch để xử lý ngoại lệ
            while (true)
            {
                try
                {
                    Console.Write("Nhap so nguyen a (4 byte): ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Nhap so nguyen b (4 byte): ");
                    b = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Loi: vui long nhap so hop le");
                }
            }

            // Tính toán và in kết quả
            Console.WriteLine();
            Console.WriteLine($"Tong cua a và b: {a + b}");
            Console.WriteLine($"Hieu cua a và b: {a - b}");
            Console.WriteLine($"Tich cua a và b: {a * b}");
            Console.WriteLine($"Thuong so nguyen a và b: {a / b}");
            Console.WriteLine($"Thuong so thuc của a và b: {(double)a / b}");

            // Bài 1b: Viết một chương trình nhận vào một mảng số nguyên có dấu kích thước 4 byte từ người dùng và tính tổng của các số trong mảng. In kết quả lên màn hình.
            int[] numbers;
            int n, sum = 0;

            // Nhập số lượng phần tử trong mảng
            while (true)
            {
                try
                {
                    Console.Write("Nhap so luong phan tu trong mang: ");
                    n = int.Parse(Console.ReadLine());
                    if (n > 0)
                        break;
                    else
                        Console.WriteLine("So luong phan tu phai lon hon 0.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Loi: vui long nhap so hop le.");
                }
            }

            // Nhập các phần tử của mảng
            numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Nhap so nguyen thu {i + 1} (4 byte): ");
                        numbers[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Loi: vui long nhap so hop le.");
                    }
                }
                sum += numbers[i];
            }

            // In kết quả
            Console.WriteLine();
            Console.WriteLine($"Tong cua cac so trong mang: {sum}");

            // Bài 1c: Viết một chương trình C# model console nhận vào một số nguyên không dấu kích thước 4 byte từ người dùng và đảo ngược các chữ số của số đó. In kết quả lên màn hình.
            uint number;

            // Nhập số nguyên không dấu
            while (true)
            {
                try
                {
                    Console.Write("Nhap so nguyen khong dau (4 byte): ");
                    number = uint.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Loi: vui long nhap so hop le.");
                }
            }

            // Đảo ngược các chữ số
            uint reversedNumber = 0;
            while (number > 0)
            {
                reversedNumber = reversedNumber * 10 + (number % 10);
                number /= 10;
            }

            // In kết quả
            Console.WriteLine();
            Console.WriteLine($"So dao nguoc: {reversedNumber}");
        }
    }
}