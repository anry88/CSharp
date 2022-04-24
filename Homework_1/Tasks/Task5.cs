using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Tasks
{
    internal class Task5
    {
        public static void Init()
        {
            Console.WriteLine("Добро пожаловать в задание 5!");
            Console.WriteLine("Сейчас мы выведем на экран информацию о вас");
        }

        public static void Execute()
        {
            string firstName = "Андрей";
            string secondName = "Бражников";
            string city = "Волжский";

            string target = $"{firstName} {secondName} город {city}";

            int width = (Console.WindowWidth - target.Length) / 2;
            int height = Console.WindowHeight / 2;

            Console.Clear();
            Task6.Print(target, width, height);

            Console.WriteLine();
        }
    }
}
