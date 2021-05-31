using System;
using System.Linq;

namespace SumOfPositive
{
    /* Метод получает массив чисел и складывает все положительные значения в нём */
    class Program
    {
        static void Main()
        {
            int[] numbers = { -1, 2, 3, 4, -5};
            Console.WriteLine(Sum(numbers));
        }
        static int Sum(int[] numbers)
        {
            int sum = default;
            for (int i =0; i<numbers.Length; i++)
            {
                if (numbers[i]>0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
            /* Linq
            return numbers.Where(x => x > 0).Sum(); */
        }
    }
}
