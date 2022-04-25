using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLibs;
using Homework_2.Tasks;

namespace Homework_2
{
    internal class Program
    {
        static string taskNumber;
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            bool isRunnig = true;

            while (isRunnig)
            {
                Console.WriteLine("Для просмотра задания введите его номер от 1 до 5 и нажмите Enter, для выхода введите 0");
                //Console.WriteLine("Задание 5 выполнено с помощью задания 6");

                taskNumber = Console.ReadLine();

                switch (taskNumber)
                {
                    case "0":
                        isRunnig = false;
                        break;
                    case "1":
                        MyLibs.Greetings("Задание 1",
                            "Написать метод, возвращающий минимальное из трёх чисел");
                        Task1.MinNumber();
                        break;
                    case "2":
                        MyLibs.Greetings("Задание 2",
                            "Написать метод подсчета количества цифр числа");
                        Task2.CountNumbers();
                        break;
                    case "3":
                        MyLibs.Greetings("Задание 2",
                            "С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех " +
                                "положительных чисел");
                        Task3.SumOddnumber();
                        break;
                    //case "4":
                    //    Task4();
                    //    break;
                    //case "5":
                    //    Task5();
                    //    break;
                    default:
                        Console.WriteLine("Кажется, вы где-то ошиблись. Попробуйте еще раз");
                        break;

                }
            }
        }
    }
}
