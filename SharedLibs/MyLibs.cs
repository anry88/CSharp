using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibs
{
    public class MyLibs
    {
        public static void Greetings(string taskName, string taskDescription)
        {
            Console.Clear();
            Console.WriteLine("Бражников Андрей");
            Console.WriteLine($"{taskName}");
            Console.WriteLine($"{taskDescription}");
        }
    }
}
