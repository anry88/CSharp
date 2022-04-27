using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Tasks
{
    internal class Task1
    {
        //проблема если a = b и они больше c
        public static int MinNumber()
        {
            int a, b, c;

            Console.WriteLine("Введите первое число");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            c = int.Parse(Console.ReadLine());

            int min = a;

            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }

            Console.WriteLine($"Наименьшее число: {min}");

            return min;
        }
    }
}
