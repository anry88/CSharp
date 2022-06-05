using Homework_6.Tasks;
using SharedLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
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
                Console.WriteLine("Для просмотра задания введите его номер от 1 до 3 и нажмите Enter, " +
                    "для выхода введите 0");

                taskNumber = Console.ReadLine();

                switch (taskNumber)
                {
                    case "0":
                        isRunnig = false;
                        break;
                    case "1":
                        MyLibs.Greetings("Задание 1",
                            "Изменить программу вывода таблицы функции так, " +
                            "чтобы можно было передавать функции типа double (double, double). \n" +
                            "Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).");
                        Task1.Start();
                        break;
                    case "2":
                        MyLibs.Greetings("Задание 2",
                            "Модифицировать программу нахождения минимума функции так, " +
                            "чтобы можно было передавать функцию в виде делегата.\n" +
                            "а) Сделать меню с различными функциями и представить пользователю выбор, " +
                            "для какой функции и на каком отрезке находить минимум.\n" +
                            "Использовать массив(или список) делегатов, в котором хранятся различные функции.\n" +
                            "б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.\n" +
                            "Пусть она возвращает минимум через параметр(с использованием модификатора out).");
                        //Task2.Start();
                        break;
                    case "3":
                        MyLibs.Greetings("Задание 3",
                            "Переделать программу Пример использования коллекций для решения следующих задач:\n" +
                            "а) Подсчитать количество студентов учащихся на 5 и 6 курсах;\n" +
                            "б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);\n" +
                            "в) отсортировать список по возрасту студента;\n" +
                            "г) *отсортировать список по курсу и возрасту студента; ");
                        //Task3.Start();
                        break;
                    default:
                        Console.WriteLine("Кажется, вы где-то ошиблись. Попробуйте еще раз");
                        break;

                }
            }
        }
    }
}
