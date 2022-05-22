using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания >> ");
            int n = Int32.Parse(Console.ReadLine());
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

            }                        
        }

        static void task1()
        {
            Console.WriteLine("Введите размеры матрицы:");
            string s = Console.ReadLine();
            string[] values = s.Split(' ');
            int n = int.Parse(values[0]);
            int m = int.Parse(values[1]);
            int[,] matrix = new int[n, m]; 
            task1_Fill_Matrix(matrix,n,m);

            Console.WriteLine("Matrix:");

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            var mass = new List<int>();
            task1_Matrix_To_List(mass, matrix, n, m);
            task1_Print_Answer(mass);
            Console.WriteLine("Задание выполнено!");
        }

        static void task1_Fill_Matrix(int[,] matrix, int n, int m)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    matrix[i, j] = rnd.Next(1,100);
                }
            }
            
        }
        
        static void task1_Matrix_To_List(List<int> mass, int[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; ++i)
            {
                for(int j = 0; j < m; ++j)
                {
                    mass.Add(matrix[i, j]);
                }
            }
        }

        static void task1_Print_Answer(List<int> mass)
        {
            Console.WriteLine("Матрица по диагонали:");
            for (int i = 0; i < mass.Count; ++i)
            {
                for (int j = 0; j < mass.Count; ++j)
                {
                    if (i == j)
                        Console.Write(mass[i]);
                    else
                        Console.Write(" ");
                }
                Console.Write('\n');
            }
            
        }

        static void task2()
        {
            var mass = new List<Tuple<string, string>>();
            Console.Write("Введите количество контактов: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                Console.Write("Ведите имя контакта: ");
                string item1 = Console.ReadLine();
                Console.Write("Ведите телефон или e-mail: ");
                string item2 = Console.ReadLine();
                mass.Add(new Tuple<string, string>(item1, item2));
            }
            Console.WriteLine("Ваш телефонный справочник: ");
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine($"{mass[i].Item1} {mass[i].Item2}");
            }
        }
        static void task3()
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            char[] sReverse = s.ToCharArray();
            Array.Reverse(sReverse);
            s = new string(sReverse);
            Console.WriteLine(s);

        }
        static void task4()
        {

        }

    }
}
