using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Teacher : Person
    {
        public Teacher() { }

        public Teacher(string surname, string name)
        {
            Name = name;
            Surname = surname;
        }

        public List<Student> Students { get; set; }

        public override string ToString()
        {
            return "Teacher : " + Surname + " " + Name;
        }

        public override void Print()
        {
            Console.WriteLine("I'm teacher!");
        }
    }
}
