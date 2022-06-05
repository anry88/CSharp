using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6.Tasks
{
    internal class Task1
    {
        public static void Start()
        {
            Console.WriteLine("Для демонстрации работы программы введите число x:");

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Теперь введите число y:");

            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"Результат выполнения функции a*x^2: ");
            Program.Table(Program.YMultiplyPowX, x, y);

            Console.WriteLine($"Результат выполнения функции  a*sin(x): ");
            Program.Table(Program.YMultiplySinX, x, y);
        }

        // Описываем делегат. В делегате описывается сигнатура методов, на
        // которые он сможет ссылаться в дальнейшем (хранить в себе)
        public delegate double Fun(double x, double y);
        class Program
        {
            // Создаем метод, который принимает делегат
            // На практике этот метод сможет принимать любой метод
            // с такой же сигнатурой, как у делегата
            public static void Table(Fun F, double x, double b)
            {
                Console.WriteLine("----- X ----- Y -----");
                while (x <= b)
                {
                    Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, b));
                    x += 1;
                }
                Console.WriteLine("---------------------");
            }
            // Создаем метод для передачи его в качестве параметра в Table
            public static double YMultiplyPowX(double x, double y)
            {
                return y * Math.Pow(x, 2);
            }

            public static double YMultiplySinX(double x, double y)
            {
                return y * Math.Sin(x);
            }
            /*static void Main()
            {
                // Создаем новый делегат и передаем ссылку на него в метод Table
                Console.WriteLine("Таблица функции MyFunc:");
                // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
                Table(new Fun(MyFunc), -2, 2);
                Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");

            }*/
        }
    }
}
