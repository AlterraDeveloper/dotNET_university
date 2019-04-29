using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Yield
{
    public class Numbers : IEnumerable<int>
    {
        private int startVal, step, qty;

        public Numbers(int startVal, int step, int qty)
        {
            this.startVal = startVal;
            this.step = step;
            this.qty = qty;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < qty; i++)
            {
                yield return startVal + step * i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
