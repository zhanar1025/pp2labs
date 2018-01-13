using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            //string line = Console.ReadLine();
            List<int> mkk = new List<int> ();
            for(int i = 0; i < args.Length; i++)
            {
                mkk.Add(int.Parse(args[i]));
            }
            for(int i = 0; i < mkk.Count; i++)
            {
                int n = mkk[i];
                bool prime = true;
                for(int j = 2; j * j <= n; j++)
                {
                    if (n % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime && n!=1)
                {
                    Console.WriteLine(n);
                }
            }
            Console.ReadKey();
        }
        
    }
}
