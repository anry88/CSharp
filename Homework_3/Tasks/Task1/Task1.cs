using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.Tasks.Task1
{
    internal class Task1
    {
        private static Complex complex1;
        private static Complex complex2;

        public static void Start()
        {
            Init();
            Menu();
        }
        private static void Menu()
        {
            bool isRunnig = true;

            while (isRunnig)
            {
                Console.WriteLine("Введите:\n" +
                "1 - для сложения комплексных чисел\n" +
                "2 - для вычитания из первого комплексного числа второго\n" +
                "3 - для умножения комплексных чисел\n" +
                "4 - для деления первого комплексного числа на второе\n" +
                    "0 - для выхода в главное меню");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        isRunnig = false;
                        break;
                    case "1":
                        Console.WriteLine($"Результат сложения комплексных чисел " +
                            $"{complex1} и {complex2} = {complex1.Plus(complex2)}");
                        break;
                    case "2":
                        Console.WriteLine($"Результат вычитания из {complex1} - {complex2} =  {complex1.Minus(complex2)}");
                        break;
                    case "3":
                        Console.WriteLine($"Результат умножения комплексных чисел " +
                            $"{complex1} и {complex2} = {complex1.Multiplication(complex2)}");
                        break;
                    case "4":
                        Console.WriteLine($"Результат деления {complex1} на {complex2} = {complex1.Division(complex2)}");
                        break;
                    default:
                        Console.WriteLine("Кажется, вы где-то ошиблись. Попробуйте еще раз");
                        break;
                }
            }

            

        }
        /// <summary>
        /// Метод для инициализации комплексных чисел
        /// </summary>
        private static void Init()
        {
            bool needInit = true;

            while (needInit)
            {
                try
                {
                    Console.WriteLine("Введите действительную часть первного комплексного числа:");
                    complex1.re = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите действительную часть первого комплексного числа:");
                    complex1.im = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите действительную часть второго комплексного числа:");
                    complex2.re = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите действительную часть второго комплексного числа:");
                    complex2.im = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Ваши числа:\n {complex1}\n {complex2}");
                }
                catch (Exception)
                {
                    Console.WriteLine("Кажется, вы где-то ошиблись. Попробуйте еще раз");

                }

                needInit = false;
            }            

        }
    }
}
