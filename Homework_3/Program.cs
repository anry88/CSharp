using Homework_3.Tasks;
using Homework_3.Tasks.Task1;
using SharedLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
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
                            "а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.\n" +
                            "б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.\n" +
                            "в) Добавить диалог с использованием switch демонстрирующий работу класса.");
                        Console.WriteLine("Для демонстрации работы структуры введите 0, для класса - 1");
                        Task1.Start(int.Parse(Console.ReadLine()));
                        break;
                    case "2":
                        MyLibs.Greetings("Задание 2",
                            "а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).\n" +
                            "Требуется подсчитать сумму всех нечётных положительных чисел. \n" +
                            "Сами числа и сумму вывести на экран, используя tryParse.");
                        Task2.SumOddnumber();
                        break;
                    case "3":
                        MyLibs.Greetings("Задание 3",
                            "*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. \n" +
                            "Предусмотреть методы сложения, вычитания, умножения и деления дробей. \n" +
                            "Написать программу, демонстрирующую все разработанные элементы класса.\n" +
                            "Добавить свойства типа int для доступа к числителю и знаменателю;\n" +
                            "Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;\n" +
                            "**Добавить проверку, чтобы знаменатель не равнялся 0." +
                            "Выбрасывать исключение ArgumentException(\"Знаменатель не может быть равен 0\"); \n" +
                            "***Добавить упрощение дробей.");
                        //Task3.SumOddnumber();
                        break;
                    default:
                        Console.WriteLine("Кажется, вы где-то ошиблись. Попробуйте еще раз");
                        break;

                }
            }
        }
    }
}
