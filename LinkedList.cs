﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Data_Structures_and_Algorithms___Assignment
{
    public class LinkedList<T>: System.Collections.Generic.ICollection<T>

    {
        public LinkedListNode<T> Head
        {
            get;
            private set;
        }

        public LinkedListNode<T> Tail
        { get; 
          private set; 
        }

        

        public bool IsReadOnly { get { return false; } }

        public void Add(T item)
        {
            AddFirst(item);
        }

        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }

        public void AddFirst(LinkedListNode<T> node)
        {
            LinkedListNode<T> temp = Head;

            Head = node;

            Head.Next = temp;

            Count++;

            if (Count == 1)
                Tail = Head;
        }

        public void AddLast(T value)
        {
            AddLast(new LinkedListNode<T>(value));
        }

        public void AddLast(LinkedListNode<T> node)
        {
            if (Count == 0)
                Head = node;
            else
                Tail.Next = node;
            Tail = node;
            Count++;
        }

        public void RemoveFirst()
        {
            if(Count != 0)
            {
                Head = Head.Next;
                Count--;

                if(Count == 0)
                {
                    Tail = null;
                }
            }
        }

        public void RemoveLast()
        {
            if(Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    LinkedListNode<T> current = Head;
                    while (current.Next != Tail)
                    {
                        current = current.Next;
                        

                    }
                    current.Next = null;
                    Tail = current;
                }
                Count--; 
            }
        }



        public int Count
        {
            get;
            private set;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = Head;
            while(current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
            
        }

        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = Head;

            while(current != null)
            {
                if(current.Value.Equals(item))
                {
                    if(previous != null)
                    {
                        previous.Next = current.Next;

                        if(current.Next == null)
                        {
                            Tail = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();

        }
    }
}
