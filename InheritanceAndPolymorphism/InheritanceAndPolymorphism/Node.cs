using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    [Serializable]
    public class Node : ISerializable,IPrintable
    {
        private int value;
        private Node next;

        public int Value { get; set; }
        public Node Next { get; set; }

        public Node() { }

        public Node(int value, Node next=null)
        {
            this.value = value;
            this.next = next;
        }

        public Node(SerializationInfo info, StreamingContext context)
        {
            value = (int) info.GetValue("Value", typeof(int));
            next = (Node) info.GetValue("Next", typeof(Node));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Value",value);
            info.AddValue("Next",next);
        }

        public void Print()
        {
            if(next == null) Console.Out.Write(value + " ");
            else
            {
                Console.Out.Write(value + " ");
                next.Print();
            }
        }
    }
}
