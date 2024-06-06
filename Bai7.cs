using System;

namespace NumericTypeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // a. Tính tổng hai số nguyên không dấu
            Console.Write("Nhap so nguyen khong dau thu nhat: ");
            uint num1 = uint.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen khong dau thu hai: ");
            uint num2 = uint.Parse(Console.ReadLine());
            uint sum = num1 + num2;
            Console.WriteLine($"Tong cua {num1} va {num2} la: {sum}");

            // b. Tính diện tích và chu vi hình chữ nhật
            Console.Write("Nhap chieu dai hinh chu nhat (2 byte khong dau): ");
            ushort length = ushort.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong hinh chu nhat (2 byte khong dau): ");
            ushort width = ushort.Parse(Console.ReadLine());
            uint area = (uint)length * (uint)width;
            uint perimeter = 2 * ((uint)length + (uint)width);
            Console.WriteLine($"Dien tich hinh chu nhat la: {area}");
            Console.WriteLine($"Chu vi hinh chu nhat la: {perimeter}");

            // c. Kiểm tra số nguyên 4 byte không dấu là chẵn hay lẻ
            Console.Write("Nhap so nguyen khong dau 4 byte: ");
            uint num3 = uint.Parse(Console.ReadLine());
            if (num3 % 2 == 0)
            {
                Console.WriteLine($"{num3} la so chan");
            }
            else
            {
                Console.WriteLine($"{num3} la so le");
            }

            // d. Tính tổng hai số nguyên có dấu 1 byte
            Console.Write("Nhap so nguyen co dau 1 byte thu nhat: ");
            sbyte num4 = sbyte.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen co dau 1 byte thu hai: ");
            sbyte num5 = sbyte.Parse(Console.ReadLine());
            sbyte sum2 = (sbyte)(num4 + num5);
            Console.WriteLine($"Tong cua {num4} va {num5} la: {sum2}");

            // e. Tính tổng các số từ 1 đến n
            Console.Write("Nhap so nguyen khong dau 4 byte n: ");
            uint n = uint.Parse(Console.ReadLine());
            uint sum3 = (n * (n + 1)) / 2;
            Console.WriteLine($"Tong cac so tu 1 den {n} la: {sum3}");

            // g. Tính diện tích và chu vi hình chữ nhật với số thực 8 byte
            Console.Write("Nhap chieu dai hinh chu nhat (8 byte): ");
            double length2 = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong hinh chu nhat (8 byte): ");
            double width2 = double.Parse(Console.ReadLine());
            double area2 = length2 * width2;
            double perimeter2 = 2 * (length2 + width2);
            Console.WriteLine($"Dien tich hinh chu nhat la: {area2}");
            Console.WriteLine($"Chu vi hinh chu nhat la: {perimeter2}");

            // h. Tìm số lớn nhất trong ba số nguyên
            Console.Write("Nhap so nguyen thu nhat: ");
            int num6 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen thu hai: ");
            int num7 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen thu ba: ");
            int num8 = int.Parse(Console.ReadLine());
            int max = Math.Max(Math.Max(num6, num7), num8);
            Console.WriteLine($"So lon nhat la: {max}");

            // k. Tính giai thừa của số nguyên không âm n
            Console.Write("Nhap so nguyen khong am n: ");
            uint num9 = uint.Parse(Console.ReadLine());
            uint factorial = 1;
            for (uint i = 1; i <= num9; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Giai thu cua {num9} la: {factorial}");

            // l. Kiểm tra số nguyên tố
            Console.Write("Nhap so nguyen khong am n: ");
            uint num10 = uint.Parse(Console.ReadLine());
            bool isPrime = true;
            if (num10 < 2)
            {
                isPrime = false;
            }
            else
            {
                for (uint i = 2; i <= (uint)Math.Sqrt(num10); i++)
                {
                    if (num10 % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{num10} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{num10} khong phai la so nguyen to");
            }

            // m. Kiểm tra số hoàn hảo
            Console.Write("Nhap so nguyen n: ");
            int num11 = int.Parse(Console.ReadLine());
            int sum4 = 0;
            for (int i = 1; i < num11; i++)
            {
                if (num11 % i == 0)
                {
                    sum4 += i;
                }
            }
            if (sum4 == num11)
            {
                Console.WriteLine($"{num11} la so hoan hao");
            }
            else
            {
                Console.WriteLine($"{num11} khong phai la so hoan hao");
            }
        }
    }
}
