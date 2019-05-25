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
            base.Print();
            Console.WriteLine($"Мой преподаватель : {Teacher?.Surname} {Teacher?.Name}");
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
