using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Tasks
{
    internal class Task4
    {
        public static void Init()
        {
            Console.WriteLine("Добро пожаловать в задание 4!");
            Console.WriteLine("Давайте поменяем местами ваши переменные");
        }

        public static void Execute()
        {
            Console.WriteLine("Введите первую переменную");

            string a = Console.ReadLine();

            Console.WriteLine("Введите вторую переменную");

            string b = Console.ReadLine();

            a = a + "." + b;

            b = a.Split('.')[0];

            a = a.Split('.')[1];

            Console.WriteLine($"Теперь первая переменная = {a}, а вторая = {b}");
        }
    }
}
