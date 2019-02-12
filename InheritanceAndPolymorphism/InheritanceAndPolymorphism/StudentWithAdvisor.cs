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

        public StudentWithAdvisor() { }

        public StudentWithAdvisor(string name,string surname,Teacher teacher) : base(surname,name)
        {
            Teacher = teacher;
        }

        public override void Print()
        {
            Console.WriteLine("I'm student with " + Teacher + $" at {Year} year");
        }

        public override object Clone()
        {
            return new StudentWithAdvisor()
            {
                Surname = Surname,
                Name = Name,
                Year = Year,
                Teacher = Teacher
            };
        }
    }
}
