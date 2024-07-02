using System;
using System.IO;

public static class array_float_2d
{
    public static float[,] nhapmangfloat2d(int m, int n)
    {
        float[,] arr = new float[m, n];
        Console.WriteLine($"Nhập {m} dòng, {n} cột mảng 2D số thực:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"a[{i},{j}] = ");
                arr[i, j] = float.Parse(Console.ReadLine());
            }
        }
        return arr;
    }

    public static void hienthimangfloat2d(float[,] arr)
    {
        int m = arr.GetLength(0);
        int n = arr.GetLength(1);
        Console.WriteLine("Mảng 2D số thực:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public static void ghimang2dfloat_file_csv(float[,] arr, string filename)
    {
        int m = arr.GetLength(0);
        int n = arr.GetLength(1);
        using (StreamWriter writer = new StreamWriter(filename))
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    writer.Write(arr[i, j]);
                    if (j < n - 1)
                        writer.Write(",");
                }
                writer.WriteLine();
            }
        }
        Console.WriteLine($"Đã ghi mảng 2D vào file {filename}");
    }

    public static float[,] docmang2dfloat_file_csv(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        int m = lines.Length;
        int n = lines[0].Split(',').Length;
        float[,] arr = new float[m, n];
        for (int i = 0; i < m; i++)
        {
            string[] values = lines[i].Split(',');
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = float.Parse(values[j]);
            }
        }
        Console.WriteLine($"Đã đọc mảng 2D từ file {filename}");
        return arr;
    }
}