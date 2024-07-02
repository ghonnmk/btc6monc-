using System;

public static class EditNumbers
{
    public static int nhapsonguyenduong()
    {
        int num;
        while (true)
        {
            try
            {
                Console.Write("Nhập số nguyên dương: ");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                    return num;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                Console.WriteLine("Vui lòng nhập lại.");
            }
        }
    }

    public static float nhapsothuc4byte()
    {
        float num;
        while (true)
        {
            try
            {
                Console.Write("Nhập số thực 4 byte: ");
                num = float.Parse(Console.ReadLine());
                return num;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                Console.WriteLine("Vui lòng nhập lại.");
            }
        }
    }
}