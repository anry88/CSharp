using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework_5.Tasks
{
    internal class Task1
    {
        public static void Start()
        {
            Console.Write("Введите логин. Логин должен быть от 2 до 10 символов.\n" +
                            "Разрешаются только буквы латинского алфавита или цифры, " +
                            "при этом цифра не может быть первой:\n");

            string login = Console.ReadLine();

            Console.WriteLine($"Проверка без использования регулярных выражений выявила, что ваш логин " +
                $"{CheckWithoutRegExp(login)}");
            Console.WriteLine($"Проверка с использованием регулярных выражений выявила, что ваш логин " +
                $"{CheckWithRegExp(login)}");
        }

        private static string CheckWithoutRegExp(string login)
        {
            if(login.Length < 2 || login.Length > 10)
            {
                return Mapping(false);
            }

            if (char.IsDigit(login[0]))
            {
                return Mapping(false);
            }

            foreach (char c in login)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return Mapping(false);
                }
            }

            return Mapping(true);
        }

        private static string Mapping(bool check)
        {
            if (check)
            {
                return "корректный";
            }
            else
            {
                return "не корректный";
            }
        }

        private static string CheckWithRegExp(string login)
        {
            Regex exp = new Regex("^[A-Za-z]{1}[A-Za-z0-9]{1,9}$");

            if (exp.IsMatch(login))
            {
                return Mapping(true);
            }
            else
            {
                return Mapping(false);
            }
        }
    }
}
