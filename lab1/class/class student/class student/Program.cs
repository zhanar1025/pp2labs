using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student1
{
     class student
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
        public student(string firstname, string name, int age)
        {
            this.firstname = firstname;
            lastname = name;
            this.age = age;
        }
      
        public override string ToString()
        {
            return firstname + " " + lastname + " " + age;
        }
    }
        class Program
        {
        public static void Main(string[] args)
        {
            string firstname, lastname;
            int age;

            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            student s1 = new student(firstname, lastname, age);
            Console.WriteLine(s1);
            Console.ReadKey();
        }
    }
}