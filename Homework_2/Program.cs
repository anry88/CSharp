using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    internal class Program
    {
        static string taskNumber;
        static void Main(string[] args)
        {
            
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
                    //case "1":
                    //    Task1();
                    //    break;
                    //case "2":
                    //    Task2();
                    //    break;
                    //case "3":
                    //    Task3();
                    //    break;
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
