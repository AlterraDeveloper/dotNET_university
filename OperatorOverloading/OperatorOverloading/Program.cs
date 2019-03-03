using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //    var start = DateTime.Now;
            //    Complex s4 = new Complex(-1, 0);
            //    Complex s5 = new Complex(1, 1);
            //    Complex s6 = new Complex(-1, -1);
            //    Console.WriteLine((DateTime.Now - start).Milliseconds);

            //var start = DateTime.Now;
            //ComplexStruct s1 = new ComplexStruct(0,1);
            //ComplexStruct s2 = new ComplexStruct(1,0);
            //ComplexStruct s3 = new ComplexStruct(0,-1);
            //Console.WriteLine((DateTime.Now - start).Milliseconds);

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);
            //Console.WriteLine(s5);
            //Console.WriteLine(s6);
             
            Frac f1 = new Frac(3,5);
            Frac f2 = new Frac(7,8);
            Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.ToString());
            Console.WriteLine((f1+f2).Denormalize().ToString());
            Console.WriteLine((f1-f2).ToString());
            double d = f1;
            Console.WriteLine(d);


            Console.ReadLine();

        }
    }
}
