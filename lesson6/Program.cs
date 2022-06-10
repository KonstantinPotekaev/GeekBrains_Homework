using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            Console.WriteLine("Все запущенные процессы на локальном компьютере  \n  \n  *************");
            foreach (Process process in processes)
            {
                Console.WriteLine(process.Id +" "+process.ProcessName);
            }
            Console.WriteLine("\n *************");
            Console.Write("Чтобы звершить один из процессов введите его ID или название: ");
            string s = Console.ReadLine();
            if (int.TryParse(s, out int Id))
                Process.GetProcessById(Id).Kill();
            else
            {
                Process[] localByName = Process.GetProcessesByName(s);
                foreach (Process p in localByName)
                {
                    p.Kill();
                }
            }

        }   
    }
}
