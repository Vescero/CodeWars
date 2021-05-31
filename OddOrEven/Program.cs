using System;

namespace OddOrEven
{
    /* Метод получает массив целочисленных значений, если значение чётное возвращет 
     * строку even если нечетное возвращает odd*/
    class Program
    {
        static void Main()
        {
            int[] numbersList = { -1023, 1, -2 };
            Console.WriteLine(OddEven(numbersList));
        }
        static string OddEven(int[] numbers)
        {
            if (numbers.Length <= 0)
                return "even";
            int sum = default;
            for (int i=0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            if ((sum % 2) == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
            /*linq;
             * return numbers.Sum() % 2 == 0 ? "even" : "odd" */
        }
    }
}
