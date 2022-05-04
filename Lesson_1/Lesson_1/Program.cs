using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя:");
            string s = Console.ReadLine();
            Console.WriteLine($"Привет, {s}, сегодня {DateTime.Now}");
            Console.ReadKey();
        }
    }
}
