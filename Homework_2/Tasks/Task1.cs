using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Tasks
{
    internal class Task1
    {
        //проблема если a = b и они больше c
        public static void MinNumber(int a, int b, int c)
        {
            if(a < b && a < c)
            {
                Console.WriteLine("Наименьшее число - a");
            }else if (b < a && b < c){
                Console.WriteLine("Наименьшее число - b");
            }
            else
            {
                Console.WriteLine("Наименьшее число - c");
            }
        }
    }
}
