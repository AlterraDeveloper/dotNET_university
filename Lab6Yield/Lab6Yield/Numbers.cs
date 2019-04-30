using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Yield
{
    public static class Numbers
    {
        public static IEnumerable<int> GetSequence(int startVal, int step, int qty)
        {
            for (int i = 0; i < qty; i++)
            {
                yield return startVal + step * i;
            }
        }

        public static IEnumerable<int> GetInfinitySequence()
        {
            for (int i = 0; ; i++)
            {
                yield return i;
            }
        }

        public static IEnumerable<int> GetInfinityRandomSequence()
        {
            for (int i = 0; ; i++)
            {
                yield return new Random(i).Next(0, 100);
            }
        }

        public static IEnumerable<int> TakeN(IEnumerable<int> seq, int n)
        {
            int i = 0;
            foreach (var num in seq)
            {
                if (i != n)
                {
                    i++;
                    yield return num;
                }
                else yield break;

            }
        }

        public static IEnumerable<int> GetFibonachiSequence()
        {
            int first = 0;
            yield return first;
            int second = 1;
            yield return second;

            for (; ; )
            {
                var current = first + second;
                first = second;
                second = current;
                yield return current;
            }
        }

        public static IEnumerable<int> GetLoopingSequence(IEnumerable<int> seq)
        {
            for (; ; )
            {
                foreach (var num in seq)
                {
                    yield return num;
                }
            }
        }

        public static IEnumerable<Tuple<int,int>> GetPermutations(IEnumerable<int> seq1, IEnumerable<int> seq2)
        {
            foreach (var num1 in seq1)
            {
                foreach (var num2 in seq2)
                {
                    yield return Tuple.Create(num1, num2);
                }
            }
        }

        public static IEnumerable<Tuple<int, int>> GetTuples(IEnumerable<int> seq1, IEnumerable<int> seq2)
        {
            List<int> seqList1 = new List<int>(seq1);
            List<int> seqList2 = new List<int>(seq2);

            for (int i = 0; i < Math.Min(seqList1.Count,seqList2.Count); i++)
            {
                yield return Tuple.Create(seqList1[i], seqList2[i]);
            }
        }

        public static IEnumerable<int> GetSequenceOfEvens(IEnumerable<int> seq)
        {
            foreach(var num in seq)
            {
                if (num % 2 == 0) yield return num;
            }
        }

        public static IEnumerable<int> GetSquares(IEnumerable<int> seq)
        {
            foreach (var num in seq)
            {
                yield return (int)Math.Pow(num,2);
            }
        }

        public static IEnumerable<Tuple<int, int>> GetTuplesOfNearestElements(IEnumerable<int> seq)
        {
            List<int> seqList = new List<int>(seq);
            for (int i = 0; i < seqList.Count-1; i++)
            {
                yield return Tuple.Create(seqList[i], seqList[i + 1]);
            }
        }
    }
}
