using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Yield
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Numbers numbers = new Numbers(7,3,5);
            foreach (var num in numbers)
            {
                Console.Out.WriteLine("num = {0}", num);
            }
            Console.ReadKey();
        }
    }
}
