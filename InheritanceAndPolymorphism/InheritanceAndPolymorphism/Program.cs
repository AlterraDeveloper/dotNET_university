using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> myList = new List<Person>();

            Person teach = new Teacher("Денисов", "Денис");
            for (int i = 0; i < 3; i++)
                ((Teacher)teach).Students.Add(Student.GetRandomStudent());

            int[] counter = new int[4];
            int[] cCounter = new int[4];

            myList.Add((Teacher)teach);
            myList.Add(Student.GetRandomStudent());
            var t = Teacher.GetRandomTeacher();
            t.Students.Add(new Student("Корешкова", "Виолетта"));
            myList.Add(t);
            myList.Add(new StudentWithAdvisor("Колодцева", "Марина", new Teacher("Степанов", "Степан")));
            myList.Add(new StudentWithAdvisor("Корешкова", "Виолетта", Teacher.GetRandomTeacher()));

            //foreach(var person in myList)
            //{

            //    if (person is Person) counter[0]++;
            //    if (person is Teacher) counter[1]++;
            //    if (person is Student) counter[2]++;
            //    if (person is StudentWithAdvisor) counter[3]++;

            //    if (person.GetType() == typeof(Person)) cCounter[0]++;
            //    if (person.GetType() == typeof(Teacher)) cCounter[1]++;
            //    if (person.GetType() == typeof(Student)) cCounter[2]++;
            //    if (person.GetType() == typeof(StudentWithAdvisor)) cCounter[3]++;

            //    var p = (person as Student);
            //    if (p != null) { p.Year++; }

            //    person.Print();
            //    person.PrintInheritance();
            //    Console.WriteLine("\n\n");
            //}

            //Console.WriteLine(
            //    $"Количество объектов типа Person (используя is) {counter[0]} (используя typeof) {cCounter[0]}");
            //Console.WriteLine(
            //    $"Количество объектов типа Teacher (используя is) {counter[1]} (используя typeof) {cCounter[1]}");
            //Console.WriteLine(
            //    $"Количество объектов типа Student (используя is) {counter[2]} (используя typeof) {cCounter[2]}");
            //Console.WriteLine(
            //    $"Количество объектов типа StudentWithAdvisor (используя is) {counter[3]} (используя typeof) {cCounter[3]}");

            //((Student)myList[3]).Year++;

            var students = new List<Student>();
            students.Add(new Student("a", "b",2));
            students.Add(new Student("c", "d",2));
            students.Add(new Student("e", "f",1));
            students.Add(new Student("g", "h",3));

            //Array.Sort<Student>(students.ToArray<Student>());
            students.Sort();

            foreach (var person in students)
            {
                Method(person);
            }

            //Console.WriteLine(((Student)myList[4]).CompareTo((Student)myList[3]));

            Console.ReadLine();
        }

        static void Method(IPrintable iface)
        {
            iface.Print();
            Console.WriteLine();
        }
    }
}
