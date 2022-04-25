using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Tasks
{
    internal class Task3
    {
        public static void SumOddnumber()
        {
            int i, sum = 0;

            do
            {
                i = int.Parse(Console.ReadLine());

                if (CheckPositive(i) && CheckOdd(i))
                {
                    sum += i;
                }
            } while (i != 0);


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
