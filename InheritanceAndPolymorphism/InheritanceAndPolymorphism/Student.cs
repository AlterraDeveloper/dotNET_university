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
            new Student("Симаков","Артем"),
            new Student("Ульянова","Ульяна"),
            new Student("Уткин","Вадим"),
            new Student("Светлова","Светлана"),
            new Student("Дарьянова","Дарья")
            }
        );

        public static Student GetRandomStudent()
        {
            var random = new Random();
            return students[random.Next(students.Count)];
        }

        private int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (value <= 0 || value > 6) year = 1;
                else year = value;
            }
        }

        public Student() { }

        public Student(string surname, string name, int year = 1)
        {
            Name = name;
            Surname = surname;
            this.year = year;
        }

        public override string ToString()
        {
            return "Student : " + Surname + " " + Name;
        }

        public override void Print()
        {
            Console.WriteLine($"Я студент : {Surname} {Name} учусь на {Year} курсе");
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
