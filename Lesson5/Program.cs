using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            int n = int.Parse(Console.ReadLine());
            switch (n) 
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                /*case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                case 5;
                    task5();
                    break;*/
            }
        }

        static void task1()
        {
            Console.WriteLine("Введите произвольный текст");
            string s = Console.ReadLine();
            string filename = "text.txt";
            File.AppendAllText(filename, s);
            Console.WriteLine($"Текст записан в файл text.txt \nпуть к файлу: {Path.GetFullPath(filename)}");
        }
        static void task2()
        {
            DateTime dateTime = DateTime.Now;
            File.AppendAllText("startup.txt", $"{dateTime.ToString()}\n");
        }
    }
}
