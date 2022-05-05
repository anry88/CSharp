using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4.Tasks
{
    internal static class Task2
    {
        public static void Start()
        {
            int[] arr = new int[20];

            Random r = new Random();

            Console.WriteLine();
            Console.Write($"Ваш массив: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-10000, 10001);

                if(i != arr.Length - 1)
                {
                    Console.Write(arr[i] + ", ");
                }
                else
                {
                    Console.Write(arr[i] + "\n");
                }
            }

            Console.Write("\n");

            Console.WriteLine($"Количество пар элементов массива, " +
                $"в которых только одно число делится на 3: {StaticClass.CountPairsDivisingByThree(arr)}");
            Console.WriteLine();

            //Текстовый файл упорно не перемещается в папку bin\debug при компиляции и, соответственно,
            //не находится программой в BaseDirectory. Поэтому использую другой вариант.
            //int[] arr2 = StaticClass.CoolArray(AppDomain.CurrentDomain.BaseDirectory + "Array.txt");

            int[] arr2 = StaticClass.CoolArray("..\\..\\Array.txt");

            Console.Write($"Ваш массив из файла: ");
        
            for (int i = 0; i < arr2.Length; i++)
            {
                if (i != arr2.Length - 1)
                {
                    Console.Write(arr2[i] + ", ");
                }
                else
                {
                    Console.Write(arr2[i] + "\n");
                }
            }

            Console.WriteLine($"Количество пар элементов массива, " +
                $"в которых только одно число делится на 3: {StaticClass.CountPairsDivisingByThree(arr2)}");
        }
    }

    public static class StaticClass
    {
        public static int CountPairsDivisingByThree(int[] arr)
        {
            int count = 0;

            for (int i = 1, p = arr[0]; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0 ^ p % 3 == 0)
                {
                    count++;
                    p = arr[i];
                }
            }

            return count;
        }

        public static int[] CoolArray(string filename)
        {
            int[] a = null;
            //Если файл существует
            if (File.Exists(filename))
            {
                //Считываем все строки в файл
                string[] ss = File.ReadAllLines(filename);
                a = new int[ss.Length];
                //Переводим данные из строкового формата в числовой
                for (int i = 0; i < ss.Length; i++)
                    a[i] = int.Parse(ss[i]);
            }
            else Console.WriteLine("Файл не существует");

            return a;
        }
    }
}
