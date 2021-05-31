using System;

namespace CreatePhoneNumber
{
    /* Метод получает массив чисел, из полученных чисел он должен сделать телефонный номер
     * согластно заданному форматированию  (123) 456-7890 */
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9,0 };
            Console.WriteLine(CreatePhoneNumber(numbers));
        }
        public static string CreatePhoneNumber(int[] numbers)
        {
            string number = string.Join("", numbers);   // Вывод всех элементов массива в строку
            string phoneNumber = string.Format("{0:(###) ###-####}", Convert.ToInt32(number)); // формат строки
            return phoneNumber;
        }
    }
}
