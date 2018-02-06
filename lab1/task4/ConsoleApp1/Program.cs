using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class student
        {
            public string firstname, surname;
            public int age;
            public student(string firstname,string surname ,int age)
            {
                this.firstname = firstname;
                this.surname = surname;
                this.age = age;
            }
            public override string ToString()
            {
                return "Firstname: "+firstname+"\nSurname: "+surname +"\nAge:"+age;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Firstname?");
            string firstname = Console.ReadLine();
            Console.WriteLine("Surname?");
            string surname = Console.ReadLine();
            Console.WriteLine("age?");
            int age = int.Parse(Console.ReadLine());
            student a = new student(firstname, surname, age);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
