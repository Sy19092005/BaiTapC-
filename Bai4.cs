using System;

namespace PalindromeCheckerAndArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kiểm tra số Palindrome
            Console.WriteLine("Kiem tra so Palindrome");

            Console.Write("Nhap so nguyen khong dau 8 byte: ");
            ulong number = ulong.Parse(Console.ReadLine());

            if (IsPalindrome(number))
            {
                Console.WriteLine($"{number} La so Palindrome");
            }
            else
            {
                Console.WriteLine($"{number} Khong phai la so Palindrome");
            }

            // Tính tổng các phần tử trong mảng số nguyên có dấu
            Console.WriteLine("\nTinh tong cac phan tu trong mang so nguyen co dau");

            Console.Write("Nhap kich thuoc mang: ");
            int arraySize = int.Parse(Console.ReadLine());

            long[] array = new long[arraySize];

            // Nhập các phần tử vào mảng
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Nhap so thu {i + 1}: ");
                array[i] = long.Parse(Console.ReadLine());
            }

            // Tính tổng các phần tử trong mảng
            long total = 0;
            foreach (long num in array)
            {
                total += num;
            }

            Console.WriteLine($"Tong cua cac so trong mang la: {total}");
        }

        static bool IsPalindrome(ulong number)
        {
            ulong originalNumber = number;
            ulong reversedNumber = 0;

            while (number > 0)
            {
                ulong digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }

            return originalNumber == reversedNumber;
        }
    }
}