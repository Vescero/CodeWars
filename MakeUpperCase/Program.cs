using System;

namespace MakeUpperCase
{
    class Program
    {
        /* Метод получает строку и возвращеает её значение капсом */
        static void Main()
        {
            string stringToUpper = MakeUpperCase("Hello");
            Console.WriteLine(stringToUpper);
        }
        public static string MakeUpperCase(string str)
        {
            return str.ToUpper();
        }
    }
}
