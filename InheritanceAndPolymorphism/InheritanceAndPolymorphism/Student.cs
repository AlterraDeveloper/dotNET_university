using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Student : Person
    {
        private static List<Student> students = new List<Student>(new Student[]{
            new Student("QWWERTY","!QAZ"),
            new Student("bnjknjl","34567"),
            new Student("vortbyt","r4vheiov"),
            new Student("6348fyhu4","vhruioe"),
            new Student("nvdfvbjkr","@WSXCDE#")
            }
        );

        public static Student GetRandomStudent()
        {
            return students[new Random().Next(students.Count)];
        }

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

        public override object Clone()
        {
            return new Student()
            {
                Surname = Surname,
                Name = Name,
                Year = Year
            };
        }       
    }
}
