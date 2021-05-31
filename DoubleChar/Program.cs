using System;
using System.Linq;

namespace DoubleChar
{
    /* Метод получает строку и должен повторить каждую букву строки дважды */
    class Program
    {
        static void Main()
        {
            string doubleChar = DoubleChar("Adidas");
            Console.WriteLine(doubleChar);

        }
        static string DoubleChar(string s)
        {
            return string.Join("", s.Select(y => "" + y + y));
        }
    }
}
