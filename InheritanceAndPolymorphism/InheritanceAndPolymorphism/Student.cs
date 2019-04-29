using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Student : Person, IPrintable, IComparable<Student>,ICloneable
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

        public override bool Equals(object obj)
        {
            var newObj = (obj as Student);
            if (object.ReferenceEquals(newObj, null)) return false;
            return (Name == newObj.Name && Surname == newObj.Surname && Year == newObj.Year);
        }

        public static bool operator ==(Student one, Student another)
        {
            if (object.ReferenceEquals(one, another))
            {
                return true;
            }
            if (object.ReferenceEquals(one, null) || object.ReferenceEquals(one, null))
            {
                return false;
            }
            return one.Equals(another);
        }

        public static bool operator !=(Student one, Student another)
        {
            return !(one == another);
        }

        public int CompareTo(Student other)
        {
            if (this.Year > other.Year) return 1;
            else if (this.Year < other.Year) return -1;
            return 0;
        }

        public class StudentComparer : IComparer<Student>
        {
            private string comparisonField;

            public StudentComparer(string fieldName)
            {
                comparisonField = fieldName;
            }

            public int Compare(Student x, Student y)
            {
                switch (comparisonField)
                {
                    case "Name":
                        return x.Name.CompareTo(y.Name);
                    case "Surname":
                        return x.Surname.CompareTo(y.Surname);
                    case "Year":
                        return x.Year.CompareTo(y.Year);
                    default: return 0;
                }
            }
        }

    }
}
