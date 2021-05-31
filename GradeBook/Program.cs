using System;

namespace GradeBook
{
    /* Метод получает 3 аргумента указывающих на оценку, метод считает среднее значение 
     и возвращает буквенное обозначение средней оценки*/
    class Program
    {
        static void Main()
        {

            char currentGrade = GetGrade(65, 66, 60);
            Console.WriteLine(currentGrade);
        }
        static char GetGrade(int s1, int s2, int s3)
        {
            int score = (s1 + s2 + s3) / 3;
            if (score >= 90 & score <= 100)
                return 'A';
            else if (score >= 80 & score < 90)
                return 'B';
            else if (score >= 70 & score < 80)
                return 'C';
            else if (score >= 60 & score < 70)
                return 'D';
            else
                return 'F';
            /*  
              var s = (s1 + s2 + s3)/3;
                if (60 > s) return 'F';
                if (70 > s) return 'D';
                if (80 > s) return 'C';
                if (90 > s) return 'B';
                return 'A';
             */
        }
    }
}
