using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class StudentWithAdvisor : Student
    {
        public Teacher Teacher { get; set; }

        public StudentWithAdvisor(string name,string surname,Teacher teacher) : base(surname,name)
        {
            Teacher = teacher;
        }

        public override void Print()
        {
            Console.WriteLine("I'm student with " + Teacher + $" at {Year} year");
        }
    }
}
