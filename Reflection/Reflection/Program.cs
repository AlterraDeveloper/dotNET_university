using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

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

            studentYear.SetValue(studentInstance, 5);
            studentName.SetValue(studentInstance, "Иван");
            studentSurname.SetValue(studentInstance, "Иванов");

            student.GetMethod("Print").Invoke(studentInstance, null);
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

            var dictionaryType = typeof(Dictionary<string, int>);
            var dictionary = Activator.CreateInstance(dictionaryType);

            dictionaryType.GetMethod("Add").Invoke(dictionary, new object[] { "A", 1 });
            dictionaryType.GetMethod("Add").Invoke(dictionary, new object[] { "B", 2 });
            dictionaryType.GetMethod("Add").Invoke(dictionary, new object[] { "C", 3 });

            Console.Out.WriteLine("Value from key = \"A\" : " + dictionaryType.GetMethod("get_Item").Invoke(dictionary, new[] { "A" }));
            
            using (FileSystemWatcher watcher = new FileSystemWatcher(AppContext.BaseDirectory))
            {
                Console.Out.WriteLine("Drag & drop .dll file to : " + watcher.Path);

                watcher.NotifyFilter = NotifyFilters.Size;

                watcher.Changed += (sender, e) =>
                {
                    var addedFile = new FileInfo(e.FullPath);
                    
                    if (addedFile.Extension == ".dll")
                    {
                        var plugin = Assembly.LoadFrom(e.FullPath);
                        foreach (var type in plugin.GetTypes())
                        {
                            if (type.IsClass && !type.IsAbstract)
                            {
                                if (type.GetInterfaces().FirstOrDefault(x => x.Name == "IPrintable") != null)
                                {
                                    Console.Out.Write(type.Name + " : ");
                                    var instance = Activator.CreateInstance(type);
                                    type.GetMethod("Print").Invoke(instance, null);
                                    Console.Out.WriteLine("");
                                }
                            }
                        }
                    }
                    
                };

                watcher.EnableRaisingEvents = true;

                while (Console.ReadKey() == null) ;
            }
        }
    }
}
