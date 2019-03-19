using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var entity = new MyByteArray(15);
            entity.Print();
            Console.WriteLine();
            entity.Fill();
            entity.Print();
            Console.WriteLine("\n\n-------------------\n\n");

            entity[5] = 55;
            entity[6] = 66;
            entity[7] = 77;


            for(int i = 0; i < entity.Length; i++)
            {
                Console.WriteLine("["+i+"] = " + entity[i]);
            }

            var dict = new MyDictionary<int,int>();
            dict[15] = 35;
            dict[25] = 45;
            dict[15] = 100;

            Console.WriteLine("\n\n-------------------\n\n");
            Console.WriteLine(dict[15]);
            Console.WriteLine(dict[25]);
            Console.WriteLine(dict[35]);
            Console.WriteLine(dict[100]);
            Console.ReadKey();
        }
    }
}
