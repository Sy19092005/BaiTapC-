using System;
using System.Text;

namespace StringOperations
{
    class Bai9
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("a. Đảo ngược chuỗi");
            Console.WriteLine("b. Đếm số từ trong chuỗi");
            Console.Write("Nhập lựa chọn (a/b): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "a":
                    ReverseString();
                    break;
                case "b":
                    CountWords();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }

        static void ReverseString()
        {
            Console.Write("Nhập chuỗi: ");
            string input = Console.ReadLine();
            string reversed = ReverseStringHelper(input);
            Console.WriteLine("Chuỗi đảo ngược: " + reversed);
        }

        static string ReverseStringHelper(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void CountWords()
        {
            Console.Write("Nhập chuỗi: ");
            string input = Console.ReadLine();
            int wordCount = CountWordsHelper(input);
            Console.WriteLine("Số từ trong chuỗi: " + wordCount);
        }

        static int CountWordsHelper(string input)
        {
            string[] words = input.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
