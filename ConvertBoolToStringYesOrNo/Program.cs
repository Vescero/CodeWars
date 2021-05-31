using System;

namespace ConvertBoolToStringYesOrNo
{
    /* Метод получает значение булеан и в зависимсоти от значения возвращает Да или Нет */
    class Program
    {
        static void Main()
        {
            bool word = true;
            Console.WriteLine(BoolToWord(word));
        }
        public static string BoolToWord (bool word)
        {
            if (word == true)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
            /*
            return word ? "Yes" : "No"; */
        }
    }
}
