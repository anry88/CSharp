using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5.Tasks
{
    internal class Task3
    {
        public static void Start()
        {
            Console.WriteLine("Введите первую строку");

            string firstString = Console.ReadLine();

            Console.WriteLine("Введите вторую строку");

            string secondString = Console.ReadLine();

            if (CompareStrings(firstString, secondString))
            {
                Console.WriteLine("Вторая строка является перестановкой первой");
            }
            else
            {
                Console.WriteLine("Вторая строка не является перестановкой первой");
            }
        }

        private static bool CompareStrings(string firstStr, string secondStr)
        {
            List<char> cloneStr = new List<char>();


            foreach (char letter in firstStr)
            {
                cloneStr.Add(letter);
            }

            foreach (char letter in secondStr)
            {
                if (cloneStr.Contains(letter))
                {
                    cloneStr.Remove(letter);
                }
                else
                {
                    return false;
                }
            }

            if (cloneStr.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
