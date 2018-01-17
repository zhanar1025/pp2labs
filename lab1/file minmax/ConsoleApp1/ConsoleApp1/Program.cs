using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Zhanar\Desktop\pp2labs\input.txt");
            string[] s = text.Split();
            int a = 100000000;
            for (int i = 0; i < s.Length; i++)
            {
                bool k = true;
                for (int j = 2; j <= Math.Sqrt(int.Parse(s[i])); i++)
                {
                    if (int.Parse(s[i]) % j == 0)
                    {
                        k = false;
                        break;
                    }
                }
                if (k == true && int.Parse(s[i]) != 1)
                {

                    if (int.Parse(s[i]) < a)
                    {
                        a = int.Parse(s[i]);
                    }
                }
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
