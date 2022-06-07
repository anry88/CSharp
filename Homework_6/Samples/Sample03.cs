using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6.Samples
{

    delegate double DoOperation(double x, double y);

    internal class Sample03
    {

        static double Plus (double a, double b)
        {
            Console.Write($"{a} + {b}");
            return a + b;
        }

        static double Minus(double a, double b)
        {
            Console.Write($"{a} - {b}");
            return a - b;
        }

        public static double YMultiplyPowX(double x, double y)
        {
            return y * Math.Pow(x, 2);
        }

        public static double YMultiplySinX(double x, double y)
        {
            return y * Math.Sin(x);
        }

        public static double Process(DoOperation operation, double x, double y)
        {
            return operation.Invoke(x, y);
        }


        /*static void Main(string[] args)
        {
            DoOperation doOperation = Plus;
            DoOperation doOperation2 = Minus;

            Process(doOperation, 10, 15);
            Process(Minus, 10, 15);

            DoOperation doOperation3 =  delegate (double x, double y)
            {
                Console.Write($"{x} * {y}");
                return x * y;
            };

            Process(doOperation3, 4, 4);

            Process(delegate (double x, double y)
            {
                Console.Write($"{x} / {y}");
                return x / y;
            }, 4, 4);

            Console.ReadKey();
        }*/
    }
}
