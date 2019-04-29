using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Teacher : Person, ICloneable
    {
        private static List<Teacher> _teachers = new List<Teacher>(new[]{
            new Teacher("Петров","Петр"),
            new Teacher("Иванов","Иван"),
            new Teacher("Семенов","Семен"),
            new Teacher("Полянова","Полина"),
            new Teacher("Галкина","Галина")
            }
        );

        public static Teacher GetRandomTeacher()
        {
            var random = new Random();
            return _teachers[random.Next(_teachers.Count)];
        }

        public Teacher() { }

        public Teacher(string surname, string name)
        {
            Name = name;
            Surname = surname;
            Students = new List<Student>();
        }

        public List<Student> Students { get; set; }

        public override string ToString()
        {
            return "Teacher : " + Surname + " " + Name;
        }

        public override void Print()
        {
            Console.WriteLine($"Я учитель : {Surname} {Name}");
            Console.WriteLine("Мои студенты : ");
            if (Students == null || Students.Count == 0)
                Console.WriteLine("У меня пока нет студентов :(");
            else
            {
                foreach (var student in Students)
                {
                    Console.Write("\t");
                    student.Print();
                }
            }
        }

        public override object Clone()
        {
            return new Teacher()
            {
                Surname = Surname,
                Name = Name,
                Students = new List<Student>(Students)
            };
        }

        public static bool operator ==(Teacher one, Teacher another)
        {
            return (one.Name == another.Name && one.Surname == another.Surname);
        }

        public static bool operator !=(Teacher one, Teacher another)
        {
            return !(one == another);
        }
    }
}
