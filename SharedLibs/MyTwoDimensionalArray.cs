using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibs
{
    public class MyTwoDimensionalArray
    {
        #region Fields

        private int[,] arr;

        #endregion

        #region Properties

        public int this[int i, int j]
        {
            get
            {
                return arr[i, j];
            }
            set
            {
                arr[i, j] = value;
            }
        }

        public int Min
        {
            get 
            {
                int min = arr[0, 0];

                foreach (int item in arr)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                return min;
            }
        }

        public int Max
        {
            get
            {
                int max = arr[0, 0];

                foreach (int item in arr)
                {
                    if (item > max)
                    {
                        max = item;
                    }
                }
                return max;
            }
        }

        #endregion


        #region Constructors

        public MyTwoDimensionalArray(int firstDimension, int secondDimension)
        {
            Random rnd = new Random();
            this.arr = new int[firstDimension, secondDimension];

            for (int i = 0; i < firstDimension; i++)
            {
                for (int j = 0; j < secondDimension; j++)
                {
                    this.arr[i, j] = rnd.Next(-99, 100); // -99 - 99
                }
            }

        }

        public MyTwoDimensionalArray(int[,] arr)
        {
            this.arr = new int[arr.GetLength(0), arr.GetLength(1)];
        }

        public MyTwoDimensionalArray(string fileName)
        {
            this.arr = LoadArrayFromFile(fileName);
        }

        #endregion

        #region Methods
        public void PrintArray()
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
        }

        public int Summary()
        {
            int sum = 0;

            foreach (int item in arr)
            {
                sum += item;
            }

            return sum;
        }

        public int SummaryLargerThan(int target)
        {
            int sum = 0;

            foreach (int item in arr)
            {
                if (item > target)
                {
                    sum += item;
                }
                
            }

            return sum;
        }
        /// <summary>
        /// Метод нахождения максимального числа в двумерном массиве
        /// </summary>
        /// <param name="x">Номер максимального числа в первом измерении</param>
        /// <param name="y">Номер максимального числа во втором измерении</param>
        /// <returns>Максимальное число</returns>
        public int GetMaxNumber(out int x, out int y)
        {
            x = 0; 
            y = 0;

            int max = arr[x, y];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        x = i;
                        y = j;
                    }
                }
            }

            return max;
        }

        //не очень понятно из задания в каком формате хранятся данные в файле для загрузки в класс
        //поэтому сделал как захотел
        private int[,] LoadArrayFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException();

            int[,] buf = new int[1000, 1000];
            int counter = 0;

            StreamReader streamReader = new StreamReader(fileName);

            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                string[] arr = line.Split(',');

                for (int i = 0; i < arr.Length; i++)
                {
                    buf[counter, i] = int.Parse(arr[i]);
                }

                counter++;
            }

            streamReader.Close();

            int[,] array = new int[counter, counter];

            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    array[i, j] = buf[i, j];
                }
            }

            return array;
        }

        public void WriteToFile(string filename)
        {
            StreamWriter streamWriter = new StreamWriter(filename);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    streamWriter.Write($"{arr[i, j]},");
                }
                streamWriter.Write("\n");
            }
            streamWriter.Flush();
            streamWriter.Close();
        }

        #endregion
    }
}
