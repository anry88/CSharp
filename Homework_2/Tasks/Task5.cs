using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Tasks
{
    internal class Task5
    {
        static readonly double minBMI = 18.50;
        static readonly double maxBMI = 25;

        static double height;
        static double weight;

        public static void BMI()
        {
            Console.WriteLine("Для начала введите ваш вес в кг");

            string w = Console.ReadLine();

            Console.WriteLine("Теперь введите ваш рост в см");

            string h = Console.ReadLine();

            weight = double.Parse(w);
            double d = double.Parse(h);

            height = Math.Round(d / 100, 2);

            Console.WriteLine(height);

            double currentBMI = weight / (height * height);

            Console.WriteLine($"Ваш ИМТ - {currentBMI}");

            if(currentBMI < minBMI)
            {

                Console.WriteLine($"Вам необходимо набрать {CountKg(minBMI):F2} кг");
            }
            else if(currentBMI > maxBMI)
            {
                Console.WriteLine($"Вам необходимо похудеть на {CountKg(maxBMI):F2} кг");
            }
            else
            {
                Console.WriteLine("Ваш вес в норме");
            }
        }

        private static double CountKg(double targetBMI)
        {
            return Math.Abs(weight - (targetBMI * height * height));
        }
    }
}
