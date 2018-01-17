using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complex_prog
    {
        class program
        {
            static void Main(string[] args)
            {
                complex c1 = new complex(2, 3);
                complex c2 = new complex(4, 5);
                complex result = c1 + c2;
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
    }
