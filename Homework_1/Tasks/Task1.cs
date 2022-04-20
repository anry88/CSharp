using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Tasks
{
    internal class Task1
    {
        public static void Init()
        {
            Console.WriteLine("Добро пожаловать в программу \"Анкета\"!");
        }

        public static void Execute()
        {
            Console.WriteLine("Введите свое имя");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите свою фамилию");
            string secondName = Console.ReadLine();

            Console.WriteLine("Введите свой возраст");
            string age = Console.ReadLine();

            Console.WriteLine("Введите свой рост");
            string height = Console.ReadLine();

            Console.WriteLine("Введите свой вес");
            string weight = Console.ReadLine();

            Console.WriteLine("Вас зовут " + firstName + " " + secondName +
                ", ваш возраст: " + age + " лет, ваш рост: " + height +
                " см, ваш вес: " + weight + " кг");

            Console.WriteLine("Вас зовут {0} {1}, ваш возраст: {2} лет, ваш рост: {3} см, ваш вес: {4} кг",
                firstName, secondName, age, height, weight);

            Console.WriteLine($"Вас зовут {firstName} {secondName}, " +
                $"ваш возраст: {age} лет, " +
                $"ваш рост: {height} см, " +
                $"ваш вес: {weight} кг");
        }

        public static void Finish()
        {
            Console.WriteLine("Нажмите любую клавишу для возврата в главное меню");

            Console.ReadLine();
        }
    }
}
