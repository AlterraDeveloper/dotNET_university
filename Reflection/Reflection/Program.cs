using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var toRepoDir = "../../../..";
            var repoPath = Path.GetFullPath(toRepoDir);
            Console.Out.WriteLine(repoPath);

            var studentDLL = Assembly.LoadFrom(repoPath + @"\InheritanceAndPolymorphism\InheritanceAndPolymorphism\bin\Debug\InheritanceAndPolymorphism.dll");
            Type student = null;
            foreach (var t in studentDLL.GetTypes())
            {
                if (t.Name == "Student") student = t;
                Console.Out.WriteLine("t = {0}", t.Name);
            }

            Console.Out.WriteLine("\n" + student?.Name);

            var studentInstance = Activator.CreateInstance(student);

            var studentYear = student.GetProperty("Year");
            var studentName = student.GetProperty("Name");
            var studentSurname = student.GetProperty("Surname");

            studentYear.SetValue(studentInstance,5);
            studentName.SetValue(studentInstance,"Иван");
            studentSurname.SetValue(studentInstance,"Иванов");

            student.GetMethod("Print").Invoke(studentInstance,null);
            Console.Out.WriteLine(student.GetProperty("Surname").GetValue(studentInstance, null));

            var currentType = student;
            while (true)
            {
                if (currentType.Name == "Object")
                {
                    Console.Out.WriteLine(currentType.Name);
                    break;
                }
                Console.Out.Write(currentType.Name + " -> ");
                currentType = currentType.BaseType;
            }
            Console.Out.WriteLine(String.Join(",", student.GetInterfaces().Select(x => x.Name)));
            Console.ReadKey();
        }
    }
}
