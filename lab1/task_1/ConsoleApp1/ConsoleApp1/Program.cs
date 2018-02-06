using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            line = Console.ReadLine();
            args = line.Split(' ');
            foreach (string s in args)
            {
                int m = int.Parse(s);
                int cnt = 0;
                for (int i = 1; i <= m; i++)
                {
                    if (m % i == 0)
                        cnt++;

                }
                if (cnt == 2)
                    Console.WriteLine(m);
            }
            Console.ReadKey();
        }
    }
}