using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{ 
    [Serializable]
    class complexnum
    {
        public int a, b;
        public complexnum(int a1,int b1)
        {
            a = a1;
            b = b1;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
        public static complexnum operator +(complexnum c1,complexnum c2)
        {
            int dvs = c1.a * c2.b + c2.a *c1.b;
            int dvd = c1.b * c2.b;
            complexnum c = new complexnum(dvs, dvd);
            c.Simplify();
            return c;
        }
        public int Gcd(int x,int y)
        {
            while(x!=0 && y != 0)
            {
                if (x > y)
                {
                    x = x % y;
                }
                else
                {
                    y = y % x;
                }
            }
            int ans = x+y;
            return ans;
        }
        public void Simplify()
        {
            int k = Gcd(this.a, this.b);
            this.a = this.a / k;
            this.b = this.b / k;
        }
    }
}
