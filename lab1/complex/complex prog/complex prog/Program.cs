using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complex_prog
{
    class complex
    {
        public int x, y;
        public complex() { }
        public complex(int a, int b)
        {
            x = a;
            y = b;
        }
        public static complex operator +(complex c1, complex c2)
        {
            complex n = new complex();
            n.x = c1.x + c2.x;
            n.y = c1.y + c2.y;
            return n;
        }
        public override string ToString()
        {
            return x + " " + y;
        }
    }
}
