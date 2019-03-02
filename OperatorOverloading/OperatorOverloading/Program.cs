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
            Complex f = new Complex(3, -4);
            Complex s = new Complex(-1, 2);

            Console.WriteLine(f);
            Console.WriteLine(s);
            //Console.WriteLine(f/s);

            Console.ReadLine();

        }
    }
}
