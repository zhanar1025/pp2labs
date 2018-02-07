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
        static bool prime(int x)
        {
            if (x == 1)
            {
                return false;
            }
            for(int i = 2; i < Math.Sqrt(x); i++)
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
            string text =File.ReadAllText(@"C:\Users\Zhanar\Desktop\pp2labs\input.txt");
            string[] s = text.Split();
            int[] n = new int[s.Length];
            int min = 10000000;
            for (int i = 0; i < s.Length; i++)
            {
                n[i] = int.Parse(s[i]);
                if (prime(n[i]))
                {
                    if (n[i] < min)
                        min = n[i];
                }

            }
            FileStream fs = new FileStream(@"C:\Users\Zhanar\Desktop\pp2labs\answer.txt",FileMode.Create,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(min);
            sw.Close();
            fs.Close();
        }
    }
}
