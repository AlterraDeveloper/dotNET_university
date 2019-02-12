using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Teacher : Person
    {
        private static List<Teacher> _teachers = new List<Teacher>(new Teacher[]{
            new Teacher("QWWERTY","!QAZ"),
            new Teacher("bnjknjl","34567"),
            new Teacher("vortbyt","r4vheiov"),
            new Teacher("6348fyhu4","vhruioe"),
            new Teacher("nvdfvbjkr","@WSXCDE#")
            }
        );

        public static Teacher GetRandomTeacher()
        {
            return _teachers[new Random().Next(_teachers.Count)];
        }

        public Teacher() { }

        public Teacher(string surname, string name)
        {
            Name = name;
            Surname = surname;
        }

        public List<Teacher> Students { get; set; }

        public override string ToString()
        {
            return "Teacher : " + Surname + " " + Name;
        }

        public override void Print()
        {
            Console.WriteLine("I'm teacher!");
        }

        public override object Clone()
        {            
            return new Teacher()
            {
                Surname = Surname,
                Name = Name,
               Students = Students
            };
        }
    }
}
