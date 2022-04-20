using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Console.WriteLine("Для просмотра задания введите его номер и нажмите Enter, для выхода введите 0");

            taskNumber = Console.ReadLine();

            switch (taskNumber)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    Task1();
                    break;
                case "2":
                    Task2();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }

            Menu();
        }

        static void Task1()
        {
            Tasks.Task1.Init();
            Tasks.Task1.Execute();
            Tasks.Task1.Finish();
        }

        static void Task2()
        {
            Tasks.Task2.Init();
            Tasks.Task2.Execute();
            Tasks.Task2.Finish();
        }
    }
}
