using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLibs;

namespace Homework_4.Tasks
{

    /*class MyArray
    {

        #region Fields

        private int[] arr;

        #endregion

        #region Properties

        public int this[int index]
        {
            get
            {
                return arr[index];
            }

            set
            {
                arr[index] = value;
            }
        }

        #endregion

        #region Constructors


        public MyArray(int count)
        {
            Random rnd = new Random();
            this.arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                this.arr[i] = rnd.Next(-99, 100); // -99 - 99
            }

        }

        public MyArray(int[] arr)
        {
            this.arr = new int[arr.Length];
            Array.Copy(arr, this.arr, arr.Length);

        }

        public MyArray(string fileName)
        {
            this.arr = LoadArrayFromFile(fileName);
        }

        public MyArray(int size, int start, int step)
        {
            this.arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                this.arr[i] = start;
                start += step;
            }
            PrintArray();
        }

        #endregion

        #region Methods

        private int[] LoadArrayFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException();
            
            int[] buf = new int[1000];
            int counter = 0;

            // StreamWriter streamWriter = new StreamWriter(fileName);
            // streamWriter.WriteLine();

            StreamReader streamReader = new StreamReader(fileName);

            while (!streamReader.EndOfStream)
            {
                buf[counter] = int.Parse(streamReader.ReadLine());
                counter++;
            }

            streamReader.Close();

            int[] arr = new int[counter];
            Array.Copy(buf, arr, counter);
            return arr;
        }

        public void PrintArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }

        #endregion

    }*/

    internal class Task3
    {

        public static void Start()
        {
            int size, start, step;
            MyArray myArray;

            Console.WriteLine("Программа демонстрирует работу библиотеки MyArray в пространстве SharedLibs");

            Console.WriteLine("Для начала давайте наполним массив.\nВведите размер массива:");

            size = int.Parse(Console.ReadLine());

            Console.WriteLine("Теперь введите значение первого элемента в массиве:");

            start = int.Parse(Console.ReadLine());

            Console.WriteLine("И наконец введите шаг, с которым значения в массиве будут увеличиваться:");

            step = int.Parse(Console.ReadLine());

            myArray = new MyArray(size, start, step);

            Console.WriteLine("Ваш массив:\n");

            myArray.PrintArray();
            
            Console.WriteLine($"Свойство Sum вашего массива: {myArray.Sum}");

            Console.WriteLine($"Свойство MaxCount вашего массива: {myArray.MaxCount}");

            MyArray inversedArr = new MyArray(myArray.Inverse());

            Console.WriteLine("Ваш инвертированный массив:\n");

            inversedArr.PrintArray();

            Console.WriteLine("Введите число, на которое хотите умножить каждый элемент массива:");

            MyArray multipliedArr = new MyArray(myArray.Multi(int.Parse(Console.ReadLine())));

            Console.WriteLine("Ваш перемноженный массив:\n");

            multipliedArr.PrintArray();

        }
        /*static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, -5, 4, 0 };

            MyArray myArray = new MyArray(arr);
            myArray.PrintArray();

            myArray[2] = 1;

            myArray = new MyArray(AppDomain.CurrentDomain.BaseDirectory + "ArrayList.txt");

            myArray.PrintArray();

            myArray = new MyArray(20);
            myArray.PrintArray();

            Console.ReadLine();

        }*/
    }
}
