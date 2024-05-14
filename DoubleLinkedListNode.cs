using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms___Assignment
{
    public class DoubleLinkedListNode<T>
    {
        public DoubleLinkedListNode(T value)
        {
            Value = value;
        }
            public T Value;

            public DoubleLinkedListNode<T> Next { get; set; }

            public DoubleLinkedListNode<T> Previous { get; set; }


          
        
    }
}
