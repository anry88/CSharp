using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibs
{
    public class MyArray
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

        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (int item in arr)
                {
                    sum += item;
                }
                return sum;
            }
        }

        public int MaxCount
        {
            get
            {
                int max = arr[0];
                int count = 0;

                foreach (int item in arr)
                {
                    if (item > max)
                    {
                        max = item;
                        count = 1;
                    } else if (item == max)
                    {
                        count++;
                    }
                }
                return count;

            }
        }

        public Dictionary<int, int> ArrayDictionary
        {
            get
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();

                foreach (int item in arr)
                {
                    if (dict.ContainsKey(item))
                    {
                        dict[item]++;
                    }
                    else
                    {
                        dict.Add(item, 1);
                    }
                }
                return dict;
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
        }

        #endregion

        #region Methods

        private int[] LoadArrayFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException();

            int[] buf = new int[1000];
            int counter = 0;

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

        public int[] Inverse()
        {
            return Multi(-1);
        }

        public int[] Multi( int multiplicator)
        {
            int[] multipliedArr = new int[arr.Length];
            Array.Copy(arr, multipliedArr, arr.Length);

            for(int i = 0; i < multipliedArr.Length; i++)
            {
                multipliedArr[i] *= multiplicator;
            }

            return multipliedArr;
        }

        #endregion

    }
}
