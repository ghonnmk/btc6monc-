using System;

namespace ex4
{
    public class bai29c
    {
        public static void Main(string[] args)
        {
            array_double_1d ob = new array_double_1d();
            ob.setNumbers(new double[] { 1.5, 2.7, 3.9, 4.2, 5.1 });
            double min = ob.FindMin();
            double max = ob.FindMax();

            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
        }
    }// Program

    public class array_double_1d
    {
        private double[] numbers;

        public void setNumbers(double[] arr)
        {
            this.numbers = arr;
        }

        public double FindMin()
        {
            double min = this.numbers[0];
            for (int i = 1; i < this.numbers.Length; i++)
            {
                if (this.numbers[i] < min)
                {
                    min = this.numbers[i];
                }
            }
            return min;
        }

        public double FindMax()
        {
            double max = this.numbers[0];
            for (int i = 1; i < this.numbers.Length; i++)
            {
                if (this.numbers[i] > max)
                {
                    max = this.numbers[i];
                }
            }
            return max;
        }
    }// array_double_1d
}// namespace ex4