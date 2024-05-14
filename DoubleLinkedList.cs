using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms___Assignment
{
    public class DoubleLinkedList<T> : System.Collections.Generic.ICollection<T>
    {
        public DoubleLinkedListNode<T> Head { get; private set; }

        public DoubleLinkedListNode<T> Tail { get; private set; }

       



       

        public bool IsReadOnly { get { return false; } }

        public void AddFirst(T value)
        {
            AddFirst(new DoubleLinkedListNode<T>(value)); 
        }

        public void AddFirst(DoubleLinkedListNode<T> node)
        {
            DoubleLinkedListNode<T> temp = Head;

            Head = node;

            Head.Next = temp;

            if(Count == 0)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = Head;
            }
            Count++;
        }

        public void AddLast(T value)
        {
          AddLast(new DoubleLinkedListNode<T>(value));
        }


        public void  AddLast(DoubleLinkedListNode<T> node)
        {
            if(Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next =node;
                node.Previous = Tail;
            }

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

                else
                {
                    Head.Previous = null;
                }
            }
        }

        public void RemoveLast()
        {
            if(Count != 0)
            {
                if(Count == 1)
                {
                    Head = null;
                    Tail = null;

                }
                else
                {
                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                }

                Count--;
            }
        }

        public int Count
        {
            get;
            private set;
        }

        public void Add(T item)
        {
            AddFirst(item);
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            DoubleLinkedListNode<T> current =Head;
            while(current != null)
            {
                if(current.Value.Equals(item)) 
                    return true;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            DoubleLinkedListNode<T> current = Head;
            while(current != null)
            {
                array[arrayIndex++] = current.Value;
                current =current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            DoubleLinkedListNode<T> current = Head;

            while(current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public bool Remove(T item)
        {
            DoubleLinkedListNode<T> previous = null;
            DoubleLinkedListNode<T> current = Head;

            while(current != null)
            {
                if (current.Value.Equals(item))
                {
                    if(previous != null)
                    {
                        previous.Next = current.Next;

                        if(previous.Next == null)
                        {
                            Tail = previous;
                        }
                        else
                        {
                            current.Next.Previous = previous;
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
