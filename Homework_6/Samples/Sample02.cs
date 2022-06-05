using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6.Samples
{

    class User
    { 
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
    }

    internal class Sample02
    {
        static void Main(string[] args)
        {
            ArrayList usersList = new ArrayList();

            StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "UserList.txt");
            while (!streamReader.EndOfStream)
            {
                string[] parts = streamReader.ReadLine().Split(' ');

                User user = new User();
                user.Name = parts[1];
                user.Surname = parts[0];
                user.Birthday = DateTime.Parse(parts[2]);
                usersList.Add((Object)user);
            }
            streamReader.Close();

            usersList.Add((Object)1);
            usersList.Add(true);
            usersList.Add("Hello!");

            foreach (object user in usersList)
            {
                if (user is User)
                {
                    Console.WriteLine($"{((User)user).Surname} {((User)user).Name} {((User)user).Birthday.ToShortDateString()}");
                }
            }

            Console.ReadKey();

            MyList<int> myList = new MyList<int>();
            myList.Insert(0, 1);
            //myList.Insert(2, "Hello!");
            //myList.Insert(3, true);

            List<User> usersList2 = new List<User>();
            streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "UserList.txt");
            while (!streamReader.EndOfStream)
            {
                string[] parts = streamReader.ReadLine().Split(' ');

                User user = new User();
                user.Name = parts[1];
                user.Surname = parts[0];
                user.Birthday = DateTime.Parse(parts[2]);
                usersList2.Add(user);
       
            }
            streamReader.Close();

            foreach (User user in usersList2)
            {
                Console.WriteLine($"{user.Surname} {user.Name} {user.Birthday.ToShortDateString()}");
            }

            Console.ReadKey();

        }
    }

    class MyList<T>
    {
        T[] arr;

        public int Lenght
        {
            get { return arr.Length; }
        }
        
        public MyList()
        {
            arr = new T[16];
        }

        public void Insert(int i, T e)
        {
            arr[i] = e;
        }
    }
}
