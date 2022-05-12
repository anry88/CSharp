﻿using Homework_4.Tasks;
using SharedLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
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

                taskNumber = Console.ReadLine();

                switch (taskNumber)
                {
                    case "0":
                        isRunnig = false;
                        break;
                    case "1":
                        MyLibs.Greetings("Задание 1",
                            "Дан целочисленный массив из 20 элементов. \n" +
                            "Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.\n" +
                            "Заполнить случайными числами.\n" +
                            "Написать программу, позволяющую найти и вывести количество пар элементов массива, " +
                            "в которых только одно число делится на 3.\n" +
                            "В данной задаче под парой подразумевается два подряд идущих элемента массива.\n" +
                            "Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.");
                        Task1.Start();
                        break;
                    case "2":
                        MyLibs.Greetings("Задание 2",
                            "Реализуйте задачу 1 в виде статического класса StaticClass; \n" +
                            "а) Класс должен содержать статический метод, " +
                            "который принимает на вход массив и решаетзадачу 1; \n" +
                            "б) *Добавьте статический метод для считывания массива из текстового файла. " +
                            "Метод должен возвращать массив целых чисел; \n" +
                            "в)**Добавьте обработку ситуации отсутствия файла на диске");
                        Task2.Start();
                        break;
                    case "3":
                        MyLibs.Greetings("Задание 3",
                            "а) Дописать класс для работы с одномерным массивом. \n" +
                            "Реализовать конструктор, создающий массив определенного размера и " +
                            "заполняющий массив числами от начального значения с заданным шагом. \n" +
                            "Создать свойство Sum, которое возвращает сумму элементов массива, \n" +
                            "метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива " +
                            "(старый массив, остается без изменений), \n" +
                            "метод Multi, умножающий каждый элемент массива на определённое число, \n" +
                            "свойство MaxCount, возвращающее количество максимальных элементов.\n" +
                            "б) * *Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки\n" +
                            "в) ***Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary< int,int>)");
                        Task3.Start();
                        break;
                    case "4":
                        MyLibs.Greetings("Задание 4",
                            "Решить задачу с логинами из урока 2, " +
                            "только логины и пароли считать из файла в массив. \n" +
                            "Создайте структуру Account, содержащую Login и Password.");
                        Task4.Start();
                        break;
                    case "5":
                        MyLibs.Greetings("Задание 5",
                            "а) Реализовать библиотеку с классом для работы с двумерным массивом. \n" +
                            "Реализовать конструктор, заполняющий массив случайными числами. \n" +
                            "Создать методы, которые возвращают сумму всех элементов массива, " +
                            "сумму всех элементов массива больше заданного, \n" +
                            "свойство, возвращающее минимальный элемент массива, \n" +
                            "свойство, возвращающее максимальный элемент массива, \n" +
                            "метод, возвращающий номер максимального элемента массива " +
                            "(через параметры, используя модификатор ref или out).\n" +
                            "* б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.\n" +
                            "* *в) Обработать возможные исключительные ситуации при работе с файлами.");
                        Task5.Start();
                        break;
                    default:
                        Console.WriteLine("Кажется, вы где-то ошиблись. Попробуйте еще раз");
                        break;

                }
            }
        }
    }
}
