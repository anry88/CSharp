using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.Tasks
{
    internal class Task2
    {
        public static void SumOddnumber()
        {
            int res, sum = 0;
            bool isParse;

            do
            {
                isParse = int.TryParse(Console.ReadLine(), out res);

                if (CheckPositive(res) && CheckOdd(res))
                {
                    sum += res;
                }

                if (isParse)
                {
                    Console.WriteLine($"Ваше число - {res}");
                }
                else
                {
                    Console.WriteLine("Вы ввели не число");
                }
            } while (res != 0 ^ !isParse);


            Console.WriteLine($"Сумма нечетных чисел - {sum}");
        }

        private static bool CheckPositive(int number)
        {
            return number > 0;
        }

        private static bool CheckOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}
