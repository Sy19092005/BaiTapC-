uusing System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool success = false;

            do
            {
                try
                {
                    Console.Write("Nhap mot so nguyen: ");
                    num = int.Parse(Console.ReadLine());
                    success = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nhap sai dinh dang, vui long nhap lai!");
                }
            } while (!success);

            if (num > 0)
            {
                Console.WriteLine($"So {num} la so duong.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"So {num} la so am.");
            }
            else
            {
                Console.WriteLine("So {0} bang 0.", num);
            }
        }
    }