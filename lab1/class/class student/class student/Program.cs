using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    public class student
    {
        public string firstname;
        public string lastname;
        public int age;
        public student()
        {
            firstname = "Zhanar";
            lastname = "Orynbasar";
            age = 18;
        }
        public void print()
        {
            Console.WriteLine("firstname: " + firstname);
            Console.WriteLine("lastname: " + lastname);
            Console.WriteLine("age: " + age);

        }
    }
        class MainClass
        {
        public static void Main(string[] args)
        {
            student s1 = new student();
            s1.print();
            Console.ReadKey();
        }
    }
}