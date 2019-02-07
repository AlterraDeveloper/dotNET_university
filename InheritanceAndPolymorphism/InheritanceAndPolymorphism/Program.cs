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

            Person teach = new Teacher("travolta", "john");

            int[] counter = new int[4];
            int[] cCounter = new int[4];

            myList.Add(new Teacher("travolta", "john"));
            myList.Add(new Student("lebovski", "bar"));
            myList.Add(new Teacher("qwerty", "ytrewq"));
            myList.Add(new StudentWithAdvisor("fred", "demand",(Teacher)teach));
            myList.Add(new StudentWithAdvisor("mike", "mask",new Teacher("Big","D")));
            
            foreach(var person in myList)
            {

                if (person is Person) counter[0]++;
                if (person is Teacher) counter[1]++;
                if (person is Student) counter[2]++;
                if (person is StudentWithAdvisor) counter[3]++;

                if (person.GetType() == typeof(Person)) cCounter[0]++;
                if (person.GetType() == typeof(Teacher)) cCounter[1]++;
                if (person.GetType() == typeof(Student)) cCounter[2]++;
                if (person.GetType() == typeof(StudentWithAdvisor)) cCounter[3]++;

                var p = (person as Student);
                if(p != null) { p.Year++; }
                person.Print();
                Console.WriteLine(person + "\n\n");
            }

            Console.WriteLine(counter[0] + " " + counter[1] + " " + counter[2] + " " + counter[3] + " ");
            Console.WriteLine(cCounter[0] + " " + cCounter[1] + " " + cCounter[2] + " " + cCounter[3] + " ");
            Console.ReadLine();
        }
    }
}
