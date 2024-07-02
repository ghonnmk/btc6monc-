using System;

class Program
{
    static void Main(string[] args)
    {
        // Nhập số nguyên dương m, n và số thực x
        int m = EditNumbers.nhapsonguyenduong();
        int n = EditNumbers.nhapsonguyenduong();
        float x = EditNumbers.nhapsothuc4byte();

        Console.WriteLine($"m = {m}, n = {n}, x = {x}");

        // Tạo và nhập mảng 2D float
        float[,] a = array_float_2d.nhapmangfloat2d(m, n);

        // Hiển thị mảng 2D float
        array_float_2d.hienthimangfloat2d(a);

        // Ghi mảng 2D float vào file CSV
        array_float_2d.ghimang2dfloat_file_csv(a, "a2d.csv");

        // Đọc mảng 2D float từ file CSV
        float[,] b = array_float_2d.docmang2dfloat_file_csv("a2d.csv");

        // Hiển thị mảng 2D float đọc từ file
        array_float_2d.hienthimangfloat2d(b);
    }
}