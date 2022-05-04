using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.Tasks.Task1
{

    /// <summary>
    /// Структура описывает комплексное число
    /// </summary>
    struct Complex
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double im;

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public Complex Plus(Complex x)
        {
            Complex complexRes;
            complexRes.re = re + x.re;
            complexRes.im = im + x.im;
            return complexRes;
        }

        public Complex Minus(Complex x)
        {
            Complex complexRes;
            complexRes.re = re - x.re;
            complexRes.im = im - x.im;
            return complexRes;
        }

        public Complex Multiplication(Complex x)
        {
            Complex complexRes;
            complexRes.re = re * x.re;
            complexRes.im = im * x.im;
            return complexRes;
        }

        public Complex Division(Complex x)
        {
            Complex complexRes;
            complexRes.re = re / x.re;
            complexRes.im = im / x.im;
            return complexRes;
        }

        public static Complex Plus(Complex a, Complex b)
        {
            Complex complexRes;
            complexRes.re = a.re + b.re;
            complexRes.im = a.im + b.im;
            return complexRes;
        }

        //TODO: Добавить методы вычитания, умножения, деления комплексных чисел

        public override string ToString()
        {
            //return base.ToString();
            return $"{re} + {im}i";
        }


    }

    internal class Sample02
    {
        /*static void Main(string[] args)
        {
     
            long a = 1;
            char c = 'c';
            string s = "Hello!";
            bool b = true;
            Complex complex1;
            complex1.re = 5;
            complex1.im = -2;

            Complex complex2;
            complex2.re = 3;
            complex2.im = 4;

            Complex complex3 = complex1.Plus(complex2);
            //complex2.Plus(complex1);

            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine($"Результат сложения комплексных чисел {complex1} и {complex2} = {complex3}");

            Complex complex4 = Complex.Plus(complex1, complex2);

            Console.ReadLine();
        }
        */
    }
}
