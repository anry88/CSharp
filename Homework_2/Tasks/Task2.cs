using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Tasks
{
    internal class Task2
    {
        public static int CountNumbers()
        {
            int number, counter = 0;
            Console.WriteLine("Введите число");

            number = int.Parse(Console.ReadLine());

            do
            {
                number /= 10;
                counter++;
            } while(number != 0);

            Console.WriteLine($"Количество цифр - {counter}");
            return counter;
        }
    }
}
