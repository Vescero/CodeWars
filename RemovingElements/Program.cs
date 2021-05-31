using System;

namespace RemovingElements
{
    class Program
    {
        static void Main()
        {
            string[] myobjects = { "Hello", "Goodbye", "Hello Again" };
            RemoveEveryOther(myobjects);
        }
        public static object[] RemoveEveryOther(object[] arr)
        {
            for (int i = 0; i < arr.Length; i =i + 2)
            {
                Console.WriteLine(arr[i]);
            }
            return (int)1;
        }
    }
}
