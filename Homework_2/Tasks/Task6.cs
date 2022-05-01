using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Tasks
{
    internal class Task6
    {
        private static bool IsGood(int number)
        {
            if (number % SumNumbers(number) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        private static int SumNumbers(int number)
        {
            int sum = 0;

            while(number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        public static void CountGoodNumbers()
        {
            Console.WriteLine("Подсчет запущен");

            DateTime start = DateTime.Now;

            int count = 0;

            for (int i = 1; i < 1000000000; i++)
            {
                if (IsGood(i))
                {
                    count++;
                }
            }



            Console.WriteLine("Подсчет длился " + (DateTime.Now - start) + 
                " количество хороших чисел - " + count);
        }
    }
}
