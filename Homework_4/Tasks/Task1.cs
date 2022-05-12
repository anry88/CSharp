using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4.Tasks
{
    internal class Task1
    {
        private static int[] arr;
        public static void Start()
        {
            arr = new int[20];

            Random r = new Random();

            Console.WriteLine();
            Console.Write($"Ваш массив: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-10000, 10001);
                Console.Write(arr[i] + ", ");
            }

            Console.Write("\n");

            Console.WriteLine($"Количество пар элементов массива, " +
                $"в которых только одно число делится на 3: {CountPairsDivisingByThree(arr)}");
        }

        private static int CountPairsDivisingByThree(int[] arr)
        {
            int count = 0;

            for (int i = 1, p = arr[0]; i < arr.Length; i++)
            {
                if(arr[i] % 3 == 0 ^ p % 3 == 0)
                {
                    count++;
                    p = arr[i];
                }
            }

            return count;
        }
    }
}
