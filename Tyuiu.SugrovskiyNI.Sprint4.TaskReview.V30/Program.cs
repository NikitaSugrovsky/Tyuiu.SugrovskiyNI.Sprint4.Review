using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SugrovskiyNI.Sprint4.TaskReview.V30.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint4.TaskReview.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];

            string str = "684259137159648";

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Сугровский Н. И. | ИИПб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Sprint.Review4                                                               *");
            Console.WriteLine("* Задание #7                                                                   *");
            Console.WriteLine("* Вариант #30                                                                  *");
            Console.WriteLine("* Выполнил: Сугровский Никита Игоревич | ИИПб-23-1                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дана строка из одноразрядных цифр |684259137159648|                          *");
            Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3 и подсчитайте количество четных чисел.      *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            int res = ds.Calculate(n, m, str);

            Console.WriteLine("Произведение четных чисел = " + res);
            Console.ReadKey();
        }
    }
}
