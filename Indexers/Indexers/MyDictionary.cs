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
            keys = new HashSet<K>();
            values = new HashSet<V>();
        }
        private HashSet<K> keys;
        private HashSet<V> values;
        public V this[K key]
        {
            get {
                var index = keys.ToList().IndexOf(key);
                return index < 0 ? default(V) : values.ToList()[index];
            }
            set
            {
                keys.Add(key);
                values.Add(value);
            }
        }
    }
}
