using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class MyByteArray
    {
        private byte[] byteArray;

        public int Length
        {
            get { return byteArray.Length; }
        }
        public MyByteArray(int capacity)
        {
            byteArray = new byte[capacity];
        }

        public void Fill()
        {
            new Random().NextBytes(byteArray);
        }

        public void Print()
        {
            foreach(var e in byteArray)
            {
                Console.Write(e + " ");
            }
        }

        public byte this[int index]
        {
            get { return byteArray[index]; }
            set
            {
                if (index > 0 && index < byteArray.Length)
                {
                    byteArray[index] = value;
                }
            }
        }
    }
}
