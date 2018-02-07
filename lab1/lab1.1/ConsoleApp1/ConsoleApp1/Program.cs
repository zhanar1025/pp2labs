using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static bool prime(string s)
        {
            int x = int.Parse(s);
            if (x == 1)
            {
                return false;
            }
            for(int i = 2; i <x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                if (prime(args[i]))
                {
                    Console.WriteLine(args[i]);
                }
            }
          

        }
    }
}
