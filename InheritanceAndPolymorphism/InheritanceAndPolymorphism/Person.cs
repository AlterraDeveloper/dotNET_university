using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public abstract class Person : IPrintable,ICloneable,IDisposable
    {
        public string Name{get;set;}
        public string Surname { get; set; }

        public virtual void Print() { Console.WriteLine("I'm person!"); }

        public override string ToString()
        {
            return base.ToString();
        }

        public abstract object Clone();
        public void PrintInheritance()
        {
            Console.WriteLine("My Base class is : " + GetType().BaseType);
        }

        public void Dispose()
        {
            Console.Out.WriteLine("Call method Dispose()");
        }
    }
}
