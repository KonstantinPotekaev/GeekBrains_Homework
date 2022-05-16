using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете номер задание от 1 до 6");
            int x = Int32.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("Средняя температура за сутки = {0}", task_1());
                    break;
                case 2:
                    Console.WriteLine(task_2().ToString("MMMM")); ;
                    break;
                case 3:
                    task_3();
                    break;
                case 4:
                    Console.WriteLine("4 задание - рутина, не хочу делать");
                    break;
                case 5:
                    task_5();
                    break;
                case 6:
                    task_6();
                    break;

            }
        }
        static double task_1()
        {

            Console.WriteLine("Введите максимальную и минимальную температуру");
            double x = (Double.Parse(Console.ReadLine()) + Double.Parse(Console.ReadLine()))/2;
            return x;
                
        }
        static DateTime task_2()
        {
            DateTime dt = new DateTime();
            Console.WriteLine("Введите номер месяца");
            int month = Int32.Parse(Console.ReadLine());
            dt = dt.AddMonths(month - 1);
            return dt;
        }
        static void task_3()
        {
            Console.WriteLine("Введите число:");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine(x % 2 == 0 ? "Число четное" : "Число нечетное");
        }

        static void task_5()
        {
            Console.WriteLine("Введите номер месяца");
            int x = Int32.Parse(Console.ReadLine());
            if ((x == 12 || x == 1 || x == 2) && task_1() > 0)
                Console.WriteLine("Дождливая зима");
        }
        static void task_6()
        {
            Console.WriteLine("Не могли бы подсказать, как это сделать?");
        }
    }
}
