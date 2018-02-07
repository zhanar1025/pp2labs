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
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Zhanar\Desktop\pp2labs\input.txt");
            string[] s = text.Split();
            int[] n = new int[s.Length];
            int max = -98765432;
            int min = 987654;
            for(int i = 0; i < s.Length; i++)
            {
                n[i] = int.Parse(s[i]);
                if (n[i] > max)
                {
                    max = n[i];
                }
                if (n[i] < min)
                {
                    min=n[i];
                }
            }
            Console.WriteLine("max= "+max);
            Console.WriteLine("min= "+min);
            Console.ReadKey();
        }
    }
}
