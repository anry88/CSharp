﻿using Homework_5.Tasks;
using SharedLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
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
                Console.WriteLine("Для просмотра задания введите его номер от 1 до 4 и нажмите Enter, " +
                    "для выхода введите 0");

                taskNumber = Console.ReadLine();

                switch (taskNumber)
                {
                    case "0":
                        isRunnig = false;
                        break;
                    case "1":
                        MyLibs.Greetings("Задание 1",
                            "Создать программу, которая будет проверять корректность ввода логина. \n" +
                            "Корректным логином будет строка от 2 до 10 символов, \n" +
                            "содержащая только буквы латинского алфавита или цифры, " +
                            "при этом цифра не может быть первой:\n" +
                            "а) без использования регулярных выражений;\n" +
                            "б) **с использованием регулярных выражений.");
                        Task1.Start();
                        break;
                    case "2":
                        MyLibs.Greetings("Задание 2",
                            "Разработать статический класс Message, содержащий следующие статические методы для обработки текста:\n" +
                            "а) Вывести только те слова сообщения, которые содержат не более n букв.\n" +
                            "б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.\n" +
                            "в) Найти самое длинное слово сообщения.\n" +
                            "г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.\n" +
                            "д) ***Создать метод, который производит частотный анализ текста.\n" +
                            "В качестве параметра в него передается массив слов и текст, \n" +
                            "в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. \n" +
                            "Здесь требуется использовать класс Dictionary.");
                        Task2.Start();
                        break;
                    case "3":
                        MyLibs.Greetings("Задание 3",
                            "*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.\n" +
                            "Например: badc являются перестановкой abcd.");
                        Task3.Start();
                        break;
                    case "4":
                        MyLibs.Greetings("Задание 4",
                            "*Задача ЕГЭ.\n" +
                            "На вход программе подаются сведения о сдаче экзаменов учениками 9 - х классов некоторой средней школы.\n" +
                            "В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, \n" +
                            "каждая из следующих N строк имеет следующий формат:\n" +
                            "< Фамилия > < Имя > < оценки >, \n" +
                            "где < Фамилия > — строка, состоящая не более чем из 20 символов, \n" +
                            "< Имя > — строка, состоящая не более чем из 15 символов, \n" +
                            "< оценки > — через пробел три целых числа, соответствующие оценкам по пятибалльной системе.\n" +
                            " < Фамилия > и<Имя>, а также < Имя > и < оценки > разделены одним пробелом.\n" +
                            "Пример входной строки:\n" +
                            "Иванов Петр 4 5 3\n" +
                            "Требуется написать как можно более эффективную программу, " +
                            "которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников.\n" +
                            "Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших," +
                            " следует вывести и их фамилии и имена");
                        Task4.Start();
                        break;
                    default:
                        Console.WriteLine("Кажется, вы где-то ошиблись. Попробуйте еще раз");
                        break;

                }
            }
        }
    }
}
