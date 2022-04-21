using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Homework_1.Tasks;


namespace Homework_1
{
    internal class Program
    {

        static string taskNumber;

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в домашнюю работу Бражникова Андрея для первого урока!");

            Menu();
        }

        static void Menu()
        {
            bool isRunnig = true;

            while (isRunnig)
            {
                Console.WriteLine("Для просмотра задания введите его номер от 1 до 5 и нажмите Enter, для выхода введите 0");
                Console.WriteLine("Задание 5 выполнено с помощью задания 6");

                taskNumber = Console.ReadLine();

                switch (taskNumber)
                {
                    case "0":
                        isRunnig = false;
                        break;
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
                        break;
                    case "4":
                        Task4();
                        break;
                    case "5":
                        Task5();
                        break;
                    default:
                        Console.WriteLine("Кажется, вы где-то ошиблись. Попробуйте еще раз");
                        break;

                    
                }
            }
        }

        static void Finish()
        {
            Console.WriteLine("Нажмите любую клавишу для возврата в главное меню");

            Console.ReadLine();

            Console.Clear();
        }

        static void Task1()
        {
            Tasks.Task1.Init();
            Tasks.Task1.Execute();
            Finish();
        }

        static void Task2()
        {
            Tasks.Task2.Init();
            Tasks.Task2.Execute();
            Finish();
        }

        static void Task3()
        {
            Tasks.Task3.Init();
            Tasks.Task3.Execute();
            Finish();
        }

        static void Task4()
        {
            Tasks.Task4.Init();
            Tasks.Task4.Execute();
            Finish();
        }

        static void Task5()
        {
            Tasks.Task5.Init();
            Tasks.Task5.Execute();
            Finish();
        }
    }
}
