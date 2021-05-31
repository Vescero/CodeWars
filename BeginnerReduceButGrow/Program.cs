using System;

namespace BeginnerReduceButGrow
{
    /* Метод получает целочисленный массив элементов и умножает все их значения */
    class Program
    {
        static void Main()
        {
            int[] numbers = { 4, 1, 1, 1, 4 };
            int[] numbers2 = { };
            Console.WriteLine(Grow(numbers2));
        }
        static int Grow(int[] numbers)
        {
            if (numbers == null || numbers.Length<=0)
            {
                return 0;
            }
            int result = 1;
            foreach (int i in numbers)
            {
                result *= i;
            }
            return result;
        }
    }
}
