﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            //12/6 17/6;
            string c = s.Split(' ')[0];
            string d = s.Split(' ')[1];
            int a_ = int.Parse(c.Split('/')[0]);
            int b_ = int.Parse(c.Split('/')[1]);
            int c_ = int.Parse(d.Split('/')[0]);
            int d_ = int.Parse(d.Split('/')[1]);
            Complex a = new Complex(a_, b_);
            Complex b = new Complex(c_, d_);
            Complex kek = a + b;
            Console.WriteLine(kek);

        }
    }
}