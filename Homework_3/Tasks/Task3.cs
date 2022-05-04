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
        private int p;

        /// <summary>
        /// Знаменатель
        /// </summary>
        private int r;

        private double dec;

        public int P
        {
            get
            {
                return p;
            }

            set
            {
                p = value;
            }

        }

        public int R
        {
            get
            {
                return r;
            }

            set
            {
                r = value;
            }
        }

        public double Dec
        {
            get { 
                return dec; 
            }
        }

        public Fraction(int P, int R)
        {
            if (R == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }
            this.P = P;
            this.R = R;
            this.dec = Math.Round((double)P / (double)R, 2);
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{P}/{R}";
        }

        /// <summary>
        /// Нахождение НОД
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returns>НОД</returns>
        private static int GCD(int a, int b)
        {
            while (a != b)
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }

            return a;
        }

        /// <summary>
        /// Нахождение НОК
        /// </summary>
        /// <param name="a">Знаменатель первой дроби</param>
        /// <param name="b">Знаменатель второй дроби</param>
        /// <returns>НОК</returns>
        private static int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }

        public static Fraction Plus(Fraction a, Fraction b)
        {
            int lcm = LCM(a.R, b.R);

            a.P = a.P * lcm / a.R;
            b.P = b.P * lcm / b.R;

            a.R = a.R * lcm / a.R;
            b.R = b.R * lcm / b.R;

            return Simplification(new Fraction(a.P + b.P, a.R));
        }

        public static Fraction Minus(Fraction a, Fraction b)
        {
            int lcm = LCM(a.R, b.R);

            a.P = a.P * lcm / a.R;
            b.P = b.P * lcm / b.R;

            a.R = a.R * lcm / a.R;
            b.R = b.R * lcm / b.R;

            return Simplification(new Fraction(a.P - b.P, a.R));
        }
        public static Fraction Multiplication(Fraction a, Fraction b)
        {

            return Simplification(new Fraction(a.P * b.P, a.R * b.R));
        }

        public static Fraction Division(Fraction a, Fraction b)
        {

            return Simplification(new Fraction(a.P * b.R, a.R * b.P));
        }

        /// <summary>
        /// Упрощение дроби
        /// </summary>
        /// <param name="f">Целевая дробь</param>
        /// <returns>Упрощенная дробь</returns>
        public static Fraction Simplification(Fraction f)
        {
            int gcd = GCD(f.P, f.R);

            return new Fraction(f.P/gcd, f.R/gcd);
        }

    }

    internal class Task3
    {
        private static Fraction f1;
        private static Fraction f2;
        private static void Init()
        {
            bool needInit = true;

            while (needInit)
            {
                try
                {
                    Console.WriteLine("Введите числитель первой дроби:");
                    int p1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите знаменатель первой дроби:");
                    int r1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите числитель второй дроби:");
                    int p2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите знаменатель второй дроби:");
                    int r2 = int.Parse(Console.ReadLine());

                    f1 = new Fraction(p1, r1);
                    f2 = new Fraction(p2, r2);

                    Console.WriteLine($"Ваши дроби:\n {f1}\n {f2}");
                }
                catch (Exception)
                {
                    Console.WriteLine("Кажется, вы где-то ошиблись. Попробуйте еще раз");

                }

                needInit = false;
            }

        }

        private static void Menu()
        {
            bool isRunnig = true;

            while (isRunnig)
            {
                Console.WriteLine("Введите:\n" +
                "1 - для сложения дробей\n" +
                "2 - для вычитания из первой дроби второй\n" +
                "3 - для умножения дробей\n" +
                "4 - для деления первой дроби на вторую\n" +
                    "0 - для выхода в главное меню");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        isRunnig = false;
                        break;
                    case "1":
                        Console.WriteLine($"Результат сложения дробей " +
                            $"{f1} и {f2} = {Fraction.Plus(f1, f2)}");
                        break;
                    case "2":
                        Console.WriteLine($"Результат вычитания из {f1} - {f2} =  {Fraction.Minus(f1, f2)}");
                        break;
                    case "3":
                        Console.WriteLine($"Результат умножения дробей " +
                            $"{f1} и {f2} = {Fraction.Multiplication(f1, f2)}");
                        break;
                    case "4":
                        Console.WriteLine($"Результат деления {f1} на {f2} = {Fraction.Division(f1, f2)}");
                        break;
                    default:
                        Console.WriteLine("Кажется, вы где-то ошиблись. Попробуйте еще раз");
                        break;
                }
            }
        }
        public static void Start()
        {
            Init();
            Menu();
        }
    }
}
