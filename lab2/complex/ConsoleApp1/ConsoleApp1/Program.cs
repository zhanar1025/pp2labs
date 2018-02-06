using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class complex
    {
        public int a, b;
        public complex(int _a, int _b)
        {
            a = _a;
            b = _b;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
        public complex Add(complex complex2)
        {
            complex result = new complex(this.a * complex2.b + complex2.a * this.b, this.b * complex2.b);
            return result;
        }
        public complex minus(complex complex2)
        {
            complex result = new complex(this.a * complex2.b - complex2.a * this.b, this.b * complex2.b);
            return result;
        }
        public complex multiple(complex complex2)
        {
            complex result = new complex(this.a * complex2.a, this.b * complex2.b);
            return result;
        }
        public complex division(complex complex2)
        {
            complex result = new complex(this.a * complex2.b, this.b * complex2.a);
            return result;
        }
        public static complex operator +(complex c1, complex c2)
        {
            complex c = new complex(c1.a + c2.a, c1.b + c2.b);
            return c;
        }
        public void simplify()
        {
            int _a = this.a;
            int _b = this.b;
            while (_a > 0 && _b > 0)
            {
                if (_a > _b)
                {
                    _a = _a % _b;
                }
                else
                    _b = _b % _a;

            }
            int nod = _a + _b;
            a /= nod;
            b /= nod;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] s = line.Split(' ');
            string a = s[0];
            string b = s[1];
            string[] d = a.Split('/');
            string[] v = b.Split('/');

            int a1 = int.Parse(d[0]);
            int a2 = int.Parse(d[1]);
            int b1 = int.Parse(v[0]);
            int b2 = int.Parse(v[1]);

            complex t1 = new complex(a1, a2);
            complex t2 = new complex(b1, b2);
            complex t3 = t1.Add(t2);
            complex t4 = t1.minus(t2);
            complex t5 = t1.multiple(t2);
            complex t6 = t1.division(t2);
            t3.simplify();
            t4.simplify();
            t5.simplify();
            t6.simplify();
            Console.WriteLine("sum " + t3);
            Console.WriteLine("substract " + t4);
            Console.WriteLine("multi " + t5);
            Console.WriteLine("division " + t6);
            Console.ReadKey();


        }
    }
}
