using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6.Samples
{
    internal class Sample04
    {


        static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 3, 9, -1, -4, 19, 8 });
            List<int> evenList = new List<int>();

            foreach (int i in list)
            {
                if (IsEvenNumber(i))
                    evenList.Add(i);
            }

            foreach (int i in evenList)
                Console.Write($"{i}\t");
            Console.WriteLine();

            // Решение через делегат
            evenList = list.FindAll(IsEvenNumber);

            foreach (int i in evenList)
                Console.Write($"{i}\t");
            Console.WriteLine();


            // Решение через анонимный метод
            evenList = list.FindAll(delegate (int number)
            {
                return (number % 2 == 0);
            });

            foreach (int i in evenList)
                Console.Write($"{i}\t");
            Console.WriteLine();

            // через использование лямбда-выражения
            evenList = list.FindAll(number => number % 2 == 0);

            foreach (int i in evenList)
                Console.Write($"{i}\t");
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
