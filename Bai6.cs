using System;

class Program
{
    static void Main(string[] args)
    {
        // a. Tính trung bình cộng của các số trong mảng
        Console.WriteLine("a. Tính trung bình cộng của các số trong mảng:");
        double[] array = GetArrayFromUser();
        double average = CalculateAverage(array);
        Console.WriteLine($"Trung bình cộng: {average}");

        // b. Tìm giá trị lớn nhất và nhỏ nhất trong mảng
        Console.WriteLine("\nb. Tìm giá trị lớn nhất và nhỏ nhất trong mảng:");
        double max = FindMax(array);
        double min = FindMin(array);
        Console.WriteLine($"Giá trị lớn nhất: {max}");
        Console.WriteLine($"Giá trị nhỏ nhất: {min}");
    }

    static double[] GetArrayFromUser()
    {
        double[] array = new double[8];
        Console.WriteLine("Nhập 8 so thuc:");
        for (int i = 0; i < 8; i++)
        {
            array[i] = double.Parse(Console.ReadLine());
        }
        return array;
    }

    static double CalculateAverage(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / array.Length;
    }

    static double FindMax(double[] array)
    {
        double max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static double FindMin(double[] array)
    {
        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }
}