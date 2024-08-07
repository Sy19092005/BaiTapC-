﻿using System;
using System.Collections.Generic;

class Bai38
{
    static void Main()
    {
        // Tạo danh sách listf các số thực 4 byte
        List<float> listf = new List<float>();

        // Bổ sung vào cuối list các số: 3.5, -1.2, 7.8, -5
        listf.Add(3.5f);
        listf.Add(-1.2f);
        listf.Add(7.8f);
        listf.Add(-5f);

        // Duyệt danh sách theo chỉ số để hiển thị các phần tử
        Console.WriteLine("Các phần tử trong danh sách:");
        for (int i = 0; i < listf.Count; i++)
        {
            Console.WriteLine($"Phần tử {i}: {listf[i]}");
        }

        // Sắp xếp danh sách theo thứ tự tăng dần
        listf.Sort();

        // Hiển thị danh sách sau khi sắp xếp
        Console.WriteLine("\nDanh sách sau khi sắp xếp:");
        foreach (var number in listf)
        {
            Console.WriteLine(number);
        }
    }
}

