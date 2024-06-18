using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms___Assignment
{
    public class BinaryTree<T>where T : IComparable<T>
    {
        public Node<T> Root {get;set;}

        private List<T> _traversalOrder = new List<T>();  

        

        public bool Add(T value)
        {
            Node<T> before = null;
            Node<T> after = this.Root;

            while (after != null)
            {
                before = after;
                if (value.CompareTo(after.Data) < 0) 
                    after = after.LeftNode;
                else if (value.CompareTo(after.Data) > 0) 
                    after = after.RightNode;
                else
                {
                    
                    return false;
                }
            }

            Node<T> newNode = new Node<T>();
            newNode.Data = value;

            if (this.Root == null)
                this.Root = newNode;
            else
            {
                if (value.CompareTo(before.Data) < 0)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }

            return true;

        }



        public Node<T> find(T value)
        {
            return this.Find(value, this.Root);
        }


        private Node<T> Find(T value, Node<T> parent)
        {
            if (parent != null)
            {
                if (value.Equals(parent.Data)) return parent;
                if (value.CompareTo(parent.Data) < 0)
                    return Find(value, parent.LeftNode);
                else
                    return Find(value, parent.RightNode);
            }

            return null;
        }


        public void Remove(T value)
        {
            this.Root = Remove(this.Root, value);
        }

        private Node<T> Remove(Node<T> parent, T key)
        {
            if (parent == null) return parent;

            if (key.CompareTo(parent.Data) < 0) parent.LeftNode = Remove(parent.LeftNode, key);
            else if (key.CompareTo(parent.Data) > 0)
                parent.RightNode = Remove(parent.RightNode, key);

            // if value is same as parent's value, then this is the node to be deleted  
            else
            {
                // node with only one child or no child  
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;

                // node with two children: Get the inorder successor (smallest in the right subtree)  
                parent.Data = MinValue(parent.RightNode);

                // Delete the inorder successor  
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }

            return parent;
        }

        

        private T MinValue(Node<T> node)
        {
            T minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

        public void TraversePreOrder(Node<T> parent)
        {
            if (parent != null)
            {
                _traversalOrder.Add(parent.Data);
                
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }


        public void TraverseInOrder(Node<T> parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                _traversalOrder.Add(parent.Data);
               
                TraverseInOrder(parent.RightNode);
            }
        }


        public void TraversePostOrder(Node<T> parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                _traversalOrder.Add(parent.Data);
               
            }
        }

       public string TraversalOutput()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < _traversalOrder.Count; i++)
            {
                sb.Append($"{_traversalOrder[i].ToString()} ");
            }

            return sb.ToString();
        }








        private Node<T> Remove(Node<T> rightNode, int data)
        {
            throw new NotImplementedException();
        }

    }
}
