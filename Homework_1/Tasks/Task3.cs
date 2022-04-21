using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Tasks
{
    internal class Task3
    {
        public static void Init()
        {
            Console.WriteLine("Добро пожаловать в задание 3!");
            Console.WriteLine("Давайте посчитаем расстояние между двумя точками");
        }

        public static void Execute()
        {
            try
            {

                Console.WriteLine("Введите местоположение первой точки по оси x");

                int x1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите местоположение первой точки по оси y");

                int y1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите местоположение второй точки по оси x");

                int x2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите местоположение второй точки по оси y");

                int y2 = int.Parse(Console.ReadLine());

                double result = CountDistance(x1, y1, x2, y2);

                Console.WriteLine("Расстояние между точками - {0:F2}", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Кажется, вы где-то ошиблись. Попробуйте еще раз");
            }

        }

        private static double CountDistance(int x1, int y1, int x2, int y2)
        {
            double result = 0;

            result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return result;
        }

    }
}
