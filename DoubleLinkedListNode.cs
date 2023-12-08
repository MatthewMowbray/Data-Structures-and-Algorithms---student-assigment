using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms___Assignment
{
    public class DoubleLinkedListNode
    {
        public class LinkedListNode<T>
        {
            public T Value;

            public LinkedListNode<T> Next { get; set; }

            public LinkedList<T> Previous { get; set; }


            public LinkedListNode(T value)
            {
                Value = value;
            }
        }
    }
}
