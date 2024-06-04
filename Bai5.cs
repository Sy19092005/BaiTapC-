using System;

class Program
{
    static void Main(string[] args)
    {
        // a. Tìm giá trị lớn nhất và nhỏ nhất trong mảng
        Console.WriteLine("a. Tìm giá trị lớn nhất và nhỏ nhất trong mảng:");
        float[] array = GetArrayFromUser();
        float max = FindMax(array);
        float min = FindMin(array);
        Console.WriteLine($"Giá trị lớn nhất: {max}");
        Console.WriteLine($"Giá trị nhỏ nhất: {min}");

        // b. Tính tổng của các số trong mảng
        Console.WriteLine("\nb. Tính tổng của các số trong mảng:");
        float sum = CalculateSum(array);
        Console.WriteLine($"Tổng của các số trong mảng: {sum}");
    }

    static float[] GetArrayFromUser()
    {
        float[] array = new float[4];
        Console.WriteLine("Nhập 4 số thực:");
        for (int i = 0; i < 4; i++)
        {
            array[i] = float.Parse(Console.ReadLine());
        }
        return array;
    }

    static float FindMax(float[] array)
    {
        float max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static float FindMin(float[] array)
    {
        float min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    static float CalculateSum(float[] array)
    {
        float sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
}
