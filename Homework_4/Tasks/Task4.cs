using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4.Tasks
{
    internal class Task4
    {

        static readonly string login = "root";
        static readonly string password = "GeekBrains";
        public struct Account
        {
            private string login;
            private string password;

            public string Login { get { return login; } set { login = value; } }
            public string Password { get { return password; } set { password = value; } }

            
        }
        public static void Start()
        {

            Console.WriteLine("Загружаем список аккаунтов из Accounts.txt");
            
            Account[] accounts = LoadFromFile("..\\..\\Accounts.txt");

            int attemptCount = 3;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (attemptCount > 0)
                {
                    if (CheckLoginPassword(accounts[i]))
                    {
                        Console.WriteLine("Доступ разрешен");
                        break;
                    }
                    else
                    {
                        attemptCount--;
                        Console.WriteLine($"Неверный логин или пароль. Попыток осталось: {attemptCount}");
                    }
                }
                else
                {
                    Console.WriteLine("Доступ запрещен");
                }
            } 
        }

        private static Account[] LoadFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException();

            Account[] buf = new Account[100];
            int counter = 0;

            StreamReader streamReader = new StreamReader(fileName);

            while (!streamReader.EndOfStream)
            {
                string[] str = streamReader.ReadLine().Split(':');
                buf[counter].Login = str[0];
                buf[counter].Password = str[1];
                counter++;
            }

            streamReader.Close();

            Account[] arr = new Account[counter];
            Array.Copy(buf, arr, counter);
            return arr;
        }

        private static bool CheckLoginPassword(Account acc)
        {
            if (acc.Login.Equals(login) && acc.Password.Equals(password))
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
