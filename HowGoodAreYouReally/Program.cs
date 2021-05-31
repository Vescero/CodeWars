using System;

namespace HowGoodAreYouReally
{
    /* Метод получает массив целочисленных значений(оценок), получает среднее значение 
     * и сравнивает с вводимым значением(своей оценкой). Если вводимое значение больше 
     * выводит true иначе false*/
    class Program
    {
        static void Main()
        {
            int[] scoreList = { 12, 23, 34, 45, 56, 67, 78, 89, 90 };
            int myPoints = 69;
            Console.WriteLine(BetterThanAverage(scoreList, myPoints));
            
        }
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            int classScore = default;
            for (int i =0; i<ClassPoints.Length; i++)
            {
                classScore += ClassPoints[i];
            }
            classScore /= ClassPoints.Length;
            Console.WriteLine(classScore);
            if (classScore > YourPoints)
                return false;
            else
                return true;

            /* Linq;
             * return YourPoints > ClassPoints.Average(); */
        }
    }
}
