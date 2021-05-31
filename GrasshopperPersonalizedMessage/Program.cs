using System;

namespace GrasshopperPersonalizedMessage
{
    /* Метод получает 2 строки, если значения строк равны возвращает строку привет босс
     * если нет, привет гость*/
    class Program
    {
        static void Main()
        {
            string name = "Daniel";
            string name2 = "Greg";
            string owner = "Daniel";
            Console.WriteLine(Greet(name2,owner));
        }
        public static string Greet(string name, string owner)
        {
            return (name == owner) ? "Hello boss" : "Hello guest";
        }
    }
}
