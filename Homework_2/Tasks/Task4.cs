using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Tasks
{
    internal class Task4
    {
        static readonly string login = "root";
        static readonly string password = "GeekBrains";

        public static bool Authorization()
        {
            int attemptCount = 3;
            do
            {
                Console.WriteLine("Для доступа введите логин и пароль");
                Console.Write("Login: ");

                string log = Console.ReadLine();

                Console.Write("Password: ");

                string pass = Console.ReadLine();

                if(CheckLoginPassword(log, pass))
                {
                    Console.WriteLine("Доступ разрешен");
                    return true;
                }
                else
                {
                    attemptCount--;
                    Console.WriteLine($"Неверный логин или пароль. Попыток осталось: {attemptCount}");
                }

            } while (attemptCount > 0);

            Console.WriteLine("Доступ запрещен");
            return false;
        }

        private static bool CheckLoginPassword(string log, string pass)
        {
            if(log.Equals(login) && pass.Equals(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
