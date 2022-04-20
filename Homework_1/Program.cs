using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {

        static int taskNumber;

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в домашнюю работу Бражникова Андрея для первого урока!");
            Console.WriteLine("Для просмотра задания введите его номер");

            taskNumber = int.Parse(Console.ReadLine());

            switch (taskNumber)
            {
                case 1:
                    Console.WriteLine(1);
                    break;
                default: 
                    Console.WriteLine("default");
                    break;
            }
        }
    }
}
