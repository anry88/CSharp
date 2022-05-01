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

        private static ComplexClass complexClass1;
        private static ComplexClass complexClass2;

        public static void Start(int type)
        {

            if(type == 0)
            {
                InitStruct();
                MenuStruct();
            } else if(type == 1)
            {
                InitClass();
                MenuClass();
            }
            
        }
        private static void MenuStruct()
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
        private static void InitStruct()
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

        private static void MenuClass()
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
                            $"{complexClass1} и {complexClass2} = {ComplexClass.Plus(complexClass1, complexClass2)}");
                        break;
                    case "2":
                        Console.WriteLine($"Результат вычитания из {complexClass1} - {complexClass2} " +
                            $"=  {ComplexClass.Minus(complexClass1, complexClass2)}");
                        break;
                    case "3":
                        Console.WriteLine($"Результат умножения комплексных чисел " +
                            $"{complexClass1} и {complexClass2} = " +
                            $"{ComplexClass.Multiplication(complexClass1, complexClass2)}");
                        break;
                    case "4":
                        Console.WriteLine($"Результат деления {complexClass1} на {complexClass2} " +
                            $"= {ComplexClass.Division(complexClass1, complexClass2)}");
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
        private static void InitClass()
        {
            bool needInit = true;

            while (needInit)
            {
                try
                {
                    Console.WriteLine("Введите действительную часть первного комплексного числа:");
                    int re1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите действительную часть первого комплексного числа:");
                    int im1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите действительную часть второго комплексного числа:");
                    int re2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите действительную часть второго комплексного числа:");
                    int im2 = int.Parse(Console.ReadLine());

                    complexClass1 = new ComplexClass(re1, im1);
                    complexClass2 = new ComplexClass(re2, im2);

                    Console.WriteLine($"Ваши числа:\n {complexClass1}\n {complexClass2}");
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
