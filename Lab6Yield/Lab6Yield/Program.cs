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
            foreach (var num in Numbers.GetSequence(50,10,7))
            {
                Console.Out.Write(num + " ");
            }

            Console.WriteLine();
            foreach (var num in Numbers.TakeN(Numbers.GetInfinitySequence(),20))
            {
                Console.Out.Write(num + " ");
            }

            Console.WriteLine();
            foreach (var num in Numbers.TakeN(Numbers.GetInfinityRandomSequence(), 10))
            {
                Console.Out.Write(num + " ");
            }

            Console.WriteLine();
            foreach (var num in Numbers.TakeN(Numbers.GetFibonachiSequence(), 10))
            {
                Console.Out.Write(num + " ");
            }

            Console.WriteLine();
            foreach (var num in Numbers.TakeN(Numbers.GetLoopingSequence(Numbers.TakeN(Numbers.GetFibonachiSequence(),4)), 10))
            {
                Console.Out.Write(num + " ");
            }

            Console.WriteLine();
            foreach (var num in Numbers.GetPermutations(Numbers.GetSequence(1,1,2),Numbers.GetSequence(10,5,3)))
            {
                Console.Out.Write(num + " ");
            }

            Console.WriteLine();
            foreach (var num in Numbers.GetSequenceOfEvens(Numbers.TakeN(Numbers.GetFibonachiSequence(), 10)))
            {
                Console.Out.Write(num + " ");
            }

            Console.WriteLine();
            foreach (var num in Numbers.GetSquares(Numbers.GetSequence(10,1,5)))
            {
                Console.Out.Write(num + " ");
            }

            Console.WriteLine();
            foreach (var num in Numbers.GetTuplesOfNearestElements(Numbers.GetSequence(1, 1, 5)))
            {
                Console.Out.Write(num + " ");
            }

            Console.WriteLine();
            foreach (var num in Numbers.GetTuples(Numbers.GetSequence(1, 1, 3), Numbers.GetSequence(4, 1, 3)))
            {
                Console.Out.Write(num + " ");
            }

            Console.ReadKey();
        }
    }
}
