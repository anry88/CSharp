using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.Tasks
{
    /// <summary>
    /// Класс, описывающий дробь
    /// </summary>
    class Fraction
    {
        /// <summary>
        /// Числитель
        /// </summary>
        private int P;

        /// <summary>
        /// Знаменатель
        /// </summary>
        private int R;

        public Fraction(int P, int R)
        {
            this.P = P;
            this.R = R;

            Console.WriteLine(LCM(P, R));
        }

        private int LCM(int a, int b)
        {
            while (a != b)
                if (a > b)
                {
                    a = a - b;
                } else {
                    b = b - a;
                }
            return a;
        }

        private void GeneralNumber()
        {

        }
        private void Plus()
        {

        }
    }

    internal class Task3
    {
        public static void Start()
        {
            Fraction f = new Fraction(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }
    }
}
