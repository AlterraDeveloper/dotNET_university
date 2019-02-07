using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Student : Person
    {
        public int Year { get; set; }

        public Student() { }

        public Student(string surname,string name)
        {
            Name = name;
            Surname = surname;
            Year = 1;
        }

        public override string ToString()
        {
            return "Student : " + Surname + " " + Name;
        }

        public override void Print()
        {
            Console.WriteLine($"I'm student at {Year} year !");
        }
    }
}
