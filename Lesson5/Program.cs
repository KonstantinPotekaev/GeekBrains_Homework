using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
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
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                /*case 5;
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

        static void task3()
        {
            Console.WriteLine("Введите произвольный набор чисел от 0 до 255");
            string filename = "bytes.bin";
            byte[] numbers = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(i=>byte.Parse(i)).ToArray<byte>();
            File.WriteAllBytes(filename, numbers );
            Console.WriteLine($"Список чисел сохранен в файл {filename} \nпуть к файлу: {Path.GetFullPath(filename)}");
        }

        static void task4()
        {
            Console.Write("Введите путь: ");
            string s = Console.ReadLine();
            PrintDir(new DirectoryInfo(@s), "", true);
        }

        static void PrintDir(DirectoryInfo dir, string indent, bool lastdir)
        {
            string filename = "task4.txt", DirName = dir.Name;
            string k = (lastdir ? "└─" : "├");
            string s = indent + k;
            File.AppendAllText(filename, s);
            indent += lastdir ? " " : "│ ";
            File.AppendAllText(filename, DirName + '\n');

            DirectoryInfo[] subdirs = dir.GetDirectories();

            for (int i = 0; i < subdirs.Length; i++)
            {
                PrintDir(subdirs[i], indent, i == subdirs.Length - 1);
            }
        }
    }
}
