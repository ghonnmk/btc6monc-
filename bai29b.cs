using System;

namespace ex4
{
    public class bai29b
    {
        public static void Main(string[] args)
        {
            double[] numbers = { 1.5, 2.7, 3.9, 4.2, 5.1 };

            array_double_1d ob = new array_double_1d();
            double min = ob.FindMin(numbers);
            double max = ob.FindMax(numbers);

            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
        }
    }// Program

    public class array_double_1d
    {
        public double FindMin(double[] arr)
        {
            double min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public double FindMax(double[] arr)
        {
            double max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }// array_double_1d
}// namespace ex4