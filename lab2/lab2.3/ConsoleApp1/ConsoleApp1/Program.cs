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
                string s = Console.ReadLine();
                string c = s.Split(' ')[0];
                string d = s.Split(' ')[1];
                int a = int.Parse(c.Split('/')[0]);
                int b = int.Parse(c.Split('/')[1]);
                int a1 = int.Parse(d.Split('/')[0]);
                int b1 = int.Parse(d.Split('/')[1]);
                complexnum q = new complexnum(a, b);
                complexnum r = new complexnum(a1, b1);
                complexnum res = q + r;
                
            
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
