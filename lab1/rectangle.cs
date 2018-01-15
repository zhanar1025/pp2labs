using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_K
{
    class rectangle
    {
        public double width;
        public double height;
        public rectangle()
        {
            width = 10;
            height = 5;
        }
        public rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override string ToString()
        {
            return width + " " + height;
        }
        public static double findarea(double width, double height)
        {
            return width * height;
        }
        public static double findperimeter(double width, double height)
        {
            return 2 * (width + height);
        }
        class program
        {
            static void Main(string[] args)
            {
                rectangle one = new rectangle();
                double aa = double.Parse(Console.ReadLine());

                one.width = aa;
                double bb = double.Parse(Console.ReadLine());
                one.height = bb;
                Console.WriteLine(one);
                Console.WriteLine(rectangle.findarea(aa, bb));
                Console.WriteLine(rectangle.findperimeter(aa, bb));
                Console.ReadKey();
            }
        }
    }
}