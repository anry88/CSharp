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
                Console.WriteLine("Для просмотра задания введите его номер от 1 до 5 и нажмите Enter, " +
                    "для выхода введите 0");
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
                        MyLibs.Greetings("Задание 3",
                            "С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех " +
                                "нечетных положительных чисел");
                        Task3.SumOddnumber();
                        break;
                    case "4":
                        MyLibs.Greetings("Задание 4",
                            "Реализовать метод проверки логина и пароля. \n" +
                            "На вход метода подается логин и пароль. \n" +
                            "На выходе истина, если прошел авторизацию, и ложь, если не прошел \n" +
                            "(Логин: root, Password: GeekBrains). \n" +
                            "Используя метод проверки логина и пароля, написать программу: \n" +
                            "пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. \n" +
                            "С помощью цикла do while ограничить ввод пароля тремя попытками");
                        Task4.Authorization();
                        break;
                    case "5":
                        MyLibs.Greetings("Задание 5",
                            "а) Написать программу, которая запрашивает массу и рост человека, " +
                            "вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, " +
                            "набрать вес или всё в норме.\n" +
                            "б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса");
                        Task5.BMI();
                        break;
                    default:
                        Console.WriteLine("Кажется, вы где-то ошиблись. Попробуйте еще раз");
                        break;

                }
            }
        }
    }
}
