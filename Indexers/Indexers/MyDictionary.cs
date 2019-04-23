using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class MyDictionary<K, V>
        where K : struct
        where V : struct
    {

        public MyDictionary()
        {
            keys = new List<K>();
            values = new List<V>();
        }
        private List<K> keys;
        private List<V> values;
        public V this[K key]
        {
            get
            {
                var index = keys.IndexOf(key);
                return index < 0 ? default(V) : values.ToList()[index];
            }
            set
            {
                if (keys.Contains(key))
                {
                    int keyIndex = keys.IndexOf(key);
                    values[keyIndex] = value;
                }
                else
                {
                    keys.Add(key);
                    values.Add(value);
                }
            }
        }
    }
}
