using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6.Tasks
{
    internal class Task3
    {
        static int MyDelegat(Student st1, Student st2)
        // Создаем метод для сравнения для экземпляров
        {
            return String.Compare(st1.firstName, st2.firstName);
            //Сравниваем две строки
        }

        static int AgeCompare(Student st1, Student st2)
        {
            return st1.age - st2.age;
        }

        static int CourseCompare(Student st1, Student st2)
        {
            return (st1.course * 100 + st1.age) - (st2.course * 100 + st2.age);
        }
        public static void Start()
        {
            int bakalavr = 0;
            int magistr = 0;
            
            Dictionary<int, int> frequencyDic = new Dictionary<int, int>();

            List<Student> list = new List<Student>();
            // Создаем список студентов
            DateTime dt = DateTime.Now;

            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new
                    Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7])
                    , s[8]));
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;

                    //Считаем количество студентов в возрасте от 18 до 20 лет и записываем их курс в словарь
                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20)
                    {
                        int value = 1;

                        if (frequencyDic.ContainsKey(int.Parse(s[6])))
                        {
                            value++;
                            frequencyDic[int.Parse(s[6])] = value;
                        }
                        else
                        {
                            frequencyDic.Add(int.Parse(s[6]), value);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;

                }
            }
            sr.Close();

            list.Sort(new Comparison<Student>(MyDelegat));
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalavr);
            foreach (var v in list) Console.WriteLine(v.firstName);
            //Console.WriteLine(DateTime.Now - dt);

            Console.WriteLine($"На 5 и 6 курсах учится {magistr} студентов");

            foreach (var v in frequencyDic)
            {
                Console.WriteLine($"На {v.Key} курсе учится {v.Value} студентов в возрасте от 18 до 20 лет");
            }

            //Отсортированный по возрасту список
            Console.WriteLine("Отсортированный по возрасту список");

            list.Sort(new Comparison<Student>(AgeCompare));

            foreach (var v in list) Console.WriteLine($"{v.firstName} {v.age} лет");

            //Отсортированный по курсу и возрасту список
            Console.WriteLine("Отсортированный по курсу и возрасту список");

            list.Sort(new Comparison<Student>(CourseCompare));
            //list.Sort(new Comparison<Student>(AgeCompare));

            foreach (var v in list) Console.WriteLine($"{v.firstName} {v.course} курс {v.age} лет");
        }
    }

    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
        // Создаем конструктор
        public Student(string firstName, string lastName, string university,
        string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }
}
