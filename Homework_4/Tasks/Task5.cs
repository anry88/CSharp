using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLibs;

namespace Homework_4.Tasks
{
    internal class Task5
    {
        public static void Start()
        {
            int firstDimension, secondDimension;
            int x, y;

            Console.WriteLine();
            Console.WriteLine("Программа демонстрирует работу библиотеки MyTwoDimensionalArray в пространстве SharedLibs");

            Console.WriteLine("Для начала давайте наполним массив.\nВведите количество строк в массиве:");

            firstDimension = int.Parse(Console.ReadLine());

            Console.WriteLine("Теперь введите количество столбцов в массиве:");

            secondDimension = int.Parse(Console.ReadLine());

            MyTwoDimensionalArray array = new MyTwoDimensionalArray(firstDimension, secondDimension);
            
            array.PrintArray();

            Console.WriteLine($"Sum: {array.Summary()}");
            Console.WriteLine($"SumLargerThan: {array.SummaryLargerThan(50)}");
            Console.WriteLine($"Min: {array.Min}");
            Console.WriteLine($"Max: {array.Max}");
            Console.WriteLine($"MaxNumber: {array.GetMaxNumber(out x, out y)} on {x},{y}");

            Console.WriteLine("Теперь выгрузим этот массив в файл SavedArray.txt");

            array.WriteToFile("..\\..\\SavedArray.txt");

            Console.WriteLine("Теперь загрузим новый массив из файла TwoDimensionalArray.txt");

            MyTwoDimensionalArray array2 = new MyTwoDimensionalArray("..\\..\\TwoDimensionalArray.txt");

            array2.PrintArray();

            Console.WriteLine($"Sum: {array2.Summary()}");
            Console.WriteLine($"SumLargerThan: {array2.SummaryLargerThan(50)}");
            Console.WriteLine($"Min: {array2.Min}");
            Console.WriteLine($"Max: {array2.Max}");
            Console.WriteLine($"MaxNumber: {array2.GetMaxNumber(out x, out y)} on {x},{y}");

        }
    }
}
