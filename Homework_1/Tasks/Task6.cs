using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Tasks
{
    internal class Task6
    {
        public static void Pause()
        {
            Console.WriteLine("Нажмите любую клавишу для продолжения");

            Console.ReadLine();
        }

        public static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }
    }
}
