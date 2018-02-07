using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class rectangle
    {
        public int width;
        public int height;
        public int peri;
        public int area;
        public rectangle()
        {
            width = 10;
            height = 12;
        }
        public rectangle(int width,int height)
        {
            this.width = width;
            this.height = height;
        }
        public void findperi()
        {
            peri = 2 * (width + height);
        }
        public void findarea()
        {
            area = width * height;
        }
        public override string ToString()
        {
            return width+"\n"+height+"\n"+peri+"\n"+area;
        }
        static void Main(string[] args)
        {
            rectangle a = new rectangle(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
            a.findperi();
            a.findarea();
            Console.WriteLine(a);
            Console.ReadKey();

        }
    }
}
