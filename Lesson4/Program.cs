using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания >> ");
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

            }
        }
        static void task1()
        {
            Console.WriteLine("Введите фамилию, имя и отчество");
            string lastname = Console.ReadLine();
            string firstname = Console.ReadLine();
            string patronymic = Console.ReadLine();
            while (true)
            {
                Console.WriteLine(GetFullName_task1(firstname, lastname, patronymic));
                lastname = Console.ReadLine();
                firstname = Console.ReadLine();
                patronymic = Console.ReadLine();
            }
        }
        static string GetFullName_task1(string firstname, string lastname, string patronymic)
        {
            return ($"ФИО: {lastname} {firstname} {patronymic}");
        }
        static void task2()
        {
            Console.WriteLine("Введите числа в строке через пробел:");
            string s = Console.ReadLine();
            var numbers = s.Split();
            int sum = 0;
            foreach (var number in numbers)
                sum += int.Parse(number);
            Console.WriteLine(sum);

        }

        static void task3()
        {
            Console.Write("Введите номер месяца от 1 до 12");
            byte n = byte.Parse(Console.ReadLine());
            while(n < 0 || n > 12)
            {
                Console.Write("Введите номер месяца от 1 до 12");
                n = Console.ReadLine();
            }
           
            Season ans = n & Season.winter;
            Console.WriteLine(ans)
            //Хотел сделать с бит масками, но не понимаю, как...
        }

        public enum Season
        {
            winter = 0b_1,0b_10,0b_1100,
            spring = 0b_11,0b_100,0b_101,
            summer = 0b_110,0b_111,0b_1000,
            autumn = 0b_1001,0b_1010,0b_1011
        }

        static void task4()
        {
            Console.Write("Введите значение:");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(f(n));
        }

        static long f(long n)
        {
            if (n == 0)
                return 0;
            else if (n == 1 || n == 2)
                return 1;
            else
                return (f(n - 1) + f(n - 2));
;        }

    }
}
