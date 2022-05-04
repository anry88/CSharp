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
    class ComplexClass
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        private double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        private double im;

        public double Re
        {
            get
            {
                return re;
            }

            set
            {



                re = value;
            }

        }

        public double Im
        {
            get
            {
                return im;
            }

            set
            {
                im = value;
            }
        }


        public ComplexClass()
        {

        }

        public ComplexClass(double re, double im)
        {
            //if (im == 0)
            //{
            //    throw new Exception("На ноль делить нельзя!");
            //}
            this.re = re;
            this.im = im;
        }

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public ComplexClass Plus(ComplexClass x)
        {
            ComplexClass complexRes = new ComplexClass(re + x.re, im + x.im);
            //complexRes.re = re + x.re;
            //complexRes.im = im + x.im;
            return complexRes;
        }

        public static ComplexClass Plus(ComplexClass a, ComplexClass b)
        {
            ComplexClass complexRes = new ComplexClass(a.re + b.re, a.im + b.im);
            return complexRes;
        }

        public static ComplexClass Minus(ComplexClass a, ComplexClass b)
        {
            ComplexClass complexRes = new ComplexClass(a.re - b.re, a.im - b.im);
            return complexRes;
        }

        public static ComplexClass Multiplication(ComplexClass a, ComplexClass b)
        {
            ComplexClass complexRes = new ComplexClass(a.re * b.re, a.im * b.im);
            return complexRes;
        }

        public static ComplexClass Division(ComplexClass a, ComplexClass b)
        {
            ComplexClass complexRes = new ComplexClass(a.re / b.re, a.im / b.im);
            return complexRes;
        }

        //TODO: Добавить методы вычитания, умножения, деления комплексных чисел

        public override string ToString()
        {
            //return base.ToString();
            return $"{re} + {im}i";
        }


    }

    internal class Sample03
    {
        /*
        static void Main(string[] args)
        {
            ComplexClass complex1 = new ComplexClass(5, 0);
            Console.WriteLine(complex1.Re);

            ComplexClass complex2 = new ComplexClass(3, 4);
            //complex2.re = 3;
            //complex2.im = 4;

            ComplexClass complex3 = complex1.Plus(complex2);
            //complex2.Plus(complex1);

            Console.WriteLine($"Результат сложения комплексных чисел {complex1} и {complex2} = {complex3}");

            ComplexClass complex4 = ComplexClass.Plus(complex1, complex2);

            Console.ReadLine();
        }
        */
    }


}
