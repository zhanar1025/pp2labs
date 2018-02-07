using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class circle
    {
        public int rad;
        public int dia;
        public double peri;
        public double area;
        public circle()
        {
            rad = 3;
        }
        public circle(int r)
        {
            rad = r;
        }
        public void finddia()
        {
            dia = 2 * rad;
        }
        public void findperi()
        {
            peri = 2 * Math.PI * rad;
        }
        public void findarea()
        {
            area = Math.PI * rad * rad;
        }
        public override string ToString()
        {
            return rad+"\n"+ dia + "\n" + peri + "\n" + area;
        }
        static void Main(string[] args)
        {
            circle a = new circle(int.Parse(Console.ReadLine()));
            a.finddia();
            a.findperi();
            a.findarea();
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
