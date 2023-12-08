using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms___Assignment
{
    internal class BinaryTree
    {
        public Node Root {get;set;}

        public bool Add(Student student)
        {
            Node before = null;
            Node after = this.Root;

            while (after != null)
            {
                before = after;
                if (student.StudentID < after.Data) //Is new node in left tree? 
                    after = after.LeftNode;
                else if (student.StudentID > after.Data) //Is new node in right tree?
                    after = after.RightNode;
                else
                {
                    //Exist same value
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.Data = student.StudentID;

            if (this.Root == null)//Tree ise empty
                this.Root = newNode;
            else
            {
                if (student.StudentID < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }

            return true;

        }



        public Node find(Student student)
        {
            return this.Find(student, this.Root);
        }


        private Node Find(Student student, Node parent)
        {
            if (parent != null)
            {
                if (student.StudentID == parent.Data) return parent;
                if (student.StudentID < parent.Data)
                    return Find(student, parent.LeftNode);
                else
                    return Find(student, parent.RightNode);
            }

            return null;
        }


        public void Remove(Student student)
        {
            this.Root = Remove(this.Root, student);
        }

        private Node Remove(Node parent, Student key)
        {
            if (parent == null) return parent;

            if (key.StudentID < parent.Data) parent.LeftNode = Remove(parent.LeftNode, key);
            else if (key.StudentID > parent.Data)
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

        private Node Remove(Node rightNode, int data)
        {
            throw new NotImplementedException();
        }

        private int MinValue(Node node)
        {
            int minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

        public void TraversePreOrder(Node parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }


        public void TraverseInOrder(Node parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraverseInOrder(parent.RightNode);
            }
        }


        public void TraversePostOrder(Node parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }



    }
}
