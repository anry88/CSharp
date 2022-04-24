using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Tasks
{
    internal class Task2
    {
        public static void Init()
        {
            Console.WriteLine("Добро пожаловать в задание 2!");
            Console.WriteLine("Сейчас мы будем рассчитывать ваш ИМТ");
        }

        public static void Execute()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Для начала введите ваш вес в кг");

                string weight = Console.ReadLine();

                Console.WriteLine("Теперь введите ваш рост в см");

                string height = Console.ReadLine();

                try
                {
                    int w = int.Parse(weight);
                    double d = double.Parse(height);

                    double h = Math.Round(d / 100, 2);

                    Console.WriteLine(h);

                    double i = w / (h * h);

                    Console.WriteLine($"Ваш ИМТ - {i}");

                    isRunning = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Кажется, вы где-то ошиблись. Попробуйте еще раз");
                }
            }
        }

    }
}
