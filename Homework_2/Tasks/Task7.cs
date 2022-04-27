using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Tasks
{
    internal class Task7
    {
        public static void InputNumbers()
        {
            int a, b;

            Console.WriteLine("Введите первое число");
                
            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine();
            }

            Console.WriteLine("Введите второе число");
                
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine();
            }

            PrintNumbers(a, b);
            
            Console.WriteLine("Сумма чисел: " + SumNumbers(a, b));
        }

        private static void PrintNumbers(int a, int b)
        {
            if(a <= b)
            {
                Console.WriteLine($"Текущее число: {a}");
                PrintNumbers(a + 1, b);
            }
        }

        private static int SumNumbers(int a, int b)
        {
            if (a < b)
            {
                return SumNumbers(a + 1, b) + a;
            }
            else
            {
                return b;
            }
            
        }
    }
}
