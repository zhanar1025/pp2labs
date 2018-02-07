using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class student
    {
        public string name, surname;
        public int age;
        public double gpa; 
        public student(string name, string surname,int age,double gpa)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.gpa= gpa;
        }
        public override string ToString()
        {
            return "name: " + name + "\nsurname: " + surname + "\nage: " + age + "\ngpa: " + gpa;
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double gpa = double.Parse(Console.ReadLine());
            student a = new student(name, surname, age, gpa);
            Console.WriteLine(a);
            Console.ReadKey();
         
        }
    }
}
