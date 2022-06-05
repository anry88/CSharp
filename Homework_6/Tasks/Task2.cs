using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6.Tasks
{
    internal class Task2
    {

        static List<Func> funcs = Program.ListFunc;
        public static void Start()
        {
            Console.WriteLine($"Выберете функцию из списка: \n" +
                $"Введите 1 для функции \"x * x - 50 * x + 10\"\n" +
                $"Введите 2 для функции \"x * x - 5 * x + 5\"\n" +
                $"Введите 3 для функции \"x * x - 1.5 * x + 20\"");

            Func f = null;

            bool isRunnig = true;

            while (isRunnig)
            {
                int funcInt = int.Parse(Console.ReadLine());

                switch (funcInt) 
                {
                    case 1:
                        f = Program.F1;
                        isRunnig = false;
                        break;

                    case 2:
                        f = Program.F2;
                        isRunnig = false;
                        break;

                    case 3:
                        f = Program.F3;
                        isRunnig = false;
                        break;

                    default:
                        Console.WriteLine("Кажется, вы где-то ошиблись. Попробуйте еще раз");
                        break;
                }
            }
            Console.WriteLine($"Введите число, от которого необходимо начать отсчет:");

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите число, до которого необходимо считать:");

            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите шаг для подсчета:");

            int h = int.Parse(Console.ReadLine());

            Program.SaveFunc("data.bin", f, x, y, h);

            double min;

            Program.Load("data.bin", out min);

            Console.WriteLine($"Минимальное значение: {min}");
        }
    }

    delegate double Func(double x);
    internal class Program
    {
        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double F2(double x)
        {
            return x * x - 5 * x + 5;
        }
        public static double F3(double x)
        {
            return x * x - 1.5 * x + 20;
        }
        private static List<Func> listFunc = new List<Func>() { F1, F2, F3 };
        public static List<Func> ListFunc
        {
            get
            {
                return listFunc;
            }
        }

        public static void SaveFunc(string fileName, Func f, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(f(a));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double min)
        {
            List<double> doubles = new List<double>(); 
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
                doubles.Add(d);
            }
            bw.Close();
            fs.Close();

            return doubles.ToArray();
        }

        /*static void Main(string[] args)
        {
            SaveFunc("data.bin", F1, -100, 100, 0.5);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
        }*/
    }
}
