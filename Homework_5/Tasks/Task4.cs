using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5.Tasks
{
    internal class Task4
    {
        public static void Start()
        {
            Student[] students = LoadListStudents("Students.txt");

            PrintWorstStudents(students);
        }

        private static Student[] LoadListStudents(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException();

            int counter = 0;

            int countStudents = 0;

            StreamReader streamReader = new StreamReader(fileName);

            Student[] students = new Student[100];

            while (!streamReader.EndOfStream)
            {
                if (counter == 0)
                {
                    int.TryParse(streamReader.ReadLine(), out countStudents);

                    counter++;

                    continue;
                }

                string[] str = streamReader.ReadLine().Split(' ');

                Student student = new Student();

                student.LastName = str[0];
                student.FirstName = str[1];
                student.Grade1 = int.Parse(str[2]);
                student.Grade2 = int.Parse(str[3]);
                student.Grade3 = int.Parse(str[4]);

                students[counter - 1] = student;

                counter++;

                if (counter > 100)
                {
                    throw new Exception("Количество учеников не соответствует критериям.");
                }
            }

            streamReader.Close();

            if (countStudents < 10 || countStudents > 100)
            {
                throw new Exception("Количество учеников не соответствует критериям.");
            }

            Student[] newStudents = new Student[countStudents];

            Array.Copy(students, newStudents, countStudents);

            return newStudents;
        }

        private static void PrintWorstStudents(Student[] students)
        {

            HashSet<double> set = new HashSet<double>();

            foreach (Student student in students)
            {
                set.Add(student.AvgGrade = 
                    Math.Round((double)(student.Grade1 + student.Grade2 + student.Grade3) / 3));
            }

            Array avgGrade = set.ToArray();
            Array.Sort(avgGrade);
            Array.Sort(students);

            Console.WriteLine("Худшие ученики:");

            foreach (Student student in students)
            {
                if (student.AvgGrade == (double)avgGrade.GetValue(0) || 
                    student.AvgGrade == (double)avgGrade.GetValue(1) || 
                    student.AvgGrade == (double)avgGrade.GetValue(2))
                {
                    Console.WriteLine($"{student.LastName} {student.FirstName} средний балл: {student.AvgGrade}");
                }
            }
        }

    }

    internal class Student : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade1 { get; set; }
        public int Grade2 { get; set; }
        public int Grade3 { get; set; }
        public double AvgGrade 
        {
            get
            {
                return avgGrade;
            }
            set
            {
                avgGrade = value;
            }
        }
        private double avgGrade;

        public int CompareTo(object obj)
        {
            return AvgGrade.CompareTo(((Student)obj).AvgGrade);
        }
    }
}
