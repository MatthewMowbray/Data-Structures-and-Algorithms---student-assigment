
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static Data_Structures_and_Algorithms___Assignment.DoubleLinkedListNode;


namespace Data_Structures_and_Algorithms___Assignment
{
    
    
    public class StudentTest : IDisposable
    {
        
        Course Maths;
        Course Physics;
        Course Chemistry;
        Course Art;

        Enrollment enrollment1;
        Enrollment enrollment2;
        Enrollment enrollment3;
        Enrollment enrollment4;
        Enrollment enrollment5;

        Student student1;
        Student student2;
        Student student3;
        Student student4;
        Student student5;
        Student student6;
        Student student7;
        Student student8;
        Student student9;
        Student student10;
        Student[] studentArray;
        LinkedList<Student> studentLinkedList;
        BinaryTree binaryTreeStudent;
 
        private DoubleLinkedList<Student> studentLinkedListD;

        public StudentTest() 
        {
            Maths = new Course(123, "Maths 101", 600);
            Physics = new Course(134, "Quantum Physics", 750);
            Chemistry = new Course(138, "Chemistry 101", 800);
            Art = new Course(224, "Sketching", 820);

            enrollment1 = new Enrollment("12/04/23", "A", 1, Maths);
            enrollment2 = new Enrollment("24/08/23", "B", 2, Physics);
            enrollment3 = new Enrollment("11/02/23", "C", 1, Maths);
            enrollment4 = new Enrollment("13/02/23", "B", 1, Chemistry);
            enrollment5 = new Enrollment("17/02/23", "B+", 2, Art);
            //initalize 10 Student objects
            student1 = new Student(enrollment1, 1, "Bacholor of mathematics", "11/10/22", "John Smith", "JohnSmith@email.com", "8528194427");
            student2 = new Student(enrollment2, 2, "Bacholor of Physics", "15/10/22", "Sherman Burns", "ShermanBurns@email.com", "2565266996");
            student3 = new Student(enrollment3, 3, "Bacholor of Mathematics", "17/10/22", "Deann Schmidt", "DeannSchmidt@email.com", "7781968569");
            student4 = new Student(enrollment4, 12, "Bacholor of Chemistry", "17/10/22", "Freda Just", "FredaJust@email.com", "6144676236");
            student5 = new Student(enrollment4, 5, "Bacholor of Chemistry", "17/10/22", "Loren Banks", "LorenBanks@email.com", "9057000044");
            student6 = new Student(enrollment5, 6, "Bacholor of Art", "12/10/22", "Josef Cherry", "JosefCherry@email.com", "7114484099");
            student7 = new Student(enrollment2, 7, "Bacholor of Physics", "11/10/22", "Gary Little", "GaryLittle@email.com", "1253487349");
            student8 = new Student(enrollment3, 11, "Bacholor of Mathematics", "18/10/22", "John Fitzpatrick", "JohnFitzpatrick@email.com", "8161214566");
            student9 = new Student(enrollment4, 9, "Bacholor of Chemistry", "17/10/22", "Freda Floyd", "FredaFloyd@email.com", "2347210060");
            student10 = new Student(enrollment5, 10, "Bacholor of Art", "19/10/22", "RudyTaylor", "RudyTaylor@email.com", "2098431343");


            studentArray = new Student[10];
            studentArray[0] = student1;
            studentArray[1] = student2;
            studentArray[2] = student3;
            studentArray[3] = student4;
            studentArray[4] = student5;
            studentArray[5] = student6;
            studentArray[6] = student7;
            studentArray[7] = student8;
            studentArray[8] = student9;
            studentArray[9] = student10;

        }

        public void Dispose()
        {
            
        }

        //Search Algorithm Tests

        [Fact]
        public void LinearSeach()
        {

            int index = SearchAndSort.LinearSearchOfStudent(studentArray,student1);
            Assert.Equal(0, index);

        }

        [Fact]
        public void BinarySearch() 
        {
            Array.Sort(studentArray);
            int index = SearchAndSort.BinarySearchOfStudent(studentArray, student2);
            Assert.Equal(9, index);
            
        }


        //Sort Algorithm Tests

        [Fact]
        public void BubbleSort()
        {
            SearchAndSort.BubbleSortOfStudentAsc(studentArray);
            Assert.Equal("Freda Floyd", studentArray[1].Name);
            Assert.Equal("Freda Just",studentArray[2].Name);

            Assert.Equal("John Fitzpatrick", studentArray[4].Name);
            Assert.Equal("John Smith", studentArray[5].Name);

        }

        [Fact]
        public void SelectionSort()
        {
            int index = studentArray.Length - 1;
            SearchAndSort.SelectionSortOfStudent(studentArray);
            Assert.Equal("Freda Just", studentArray[index].Name);

        }


        //Single Linked List Tests
        [Fact]
        public void SingleLinkedListHead()
        {
            studentLinkedList = new LinkedList<Student>();
            studentLinkedList.AddFirst(student1);
            studentLinkedList.AddFirst(student2);
            studentLinkedList.GetEnumerator();
            LinkedListNode<Student> Head = studentLinkedList.Head;

            Assert.Equal(student2,Head.Value);

        }

        [Fact]
        public void singleLinkedListTail()
        {
            studentLinkedList = new LinkedList<Student>();
            studentLinkedList.Add(student8);
            studentLinkedList.AddLast(student2);
            LinkedListNode<Student> Tail = studentLinkedList.Tail;

            Assert.Equal(student2, Tail.Value);
        }

        [Fact]
        public void singleLinkedListContains()
        {
            studentLinkedList = new LinkedList<Student>();
            studentLinkedList.Add(student9);
            studentLinkedList.Add(student7);
            studentLinkedList.Add(student8);
            bool contains = studentLinkedList.Contains(student8);
            Assert.True(contains);
        }

        [Fact]
        public void SingleLinkedListRemove() 
        {
                studentLinkedList = new LinkedList<Student>();
                studentLinkedList.Add(student9);
                studentLinkedList.Add(student7);
                studentLinkedList.Add(student6);
                studentLinkedList.RemoveFirst();
                LinkedListNode<Student> Head = studentLinkedList.Head; 
                Assert.NotEqual<Student>(student8,Head.Value);
        }

        //Double Linked List

        [Fact]
        public void DoubleLinkedListHead()
        {
            studentLinkedListD = new DoubleLinkedList<Student>();
            studentLinkedListD.AddFirst(student1);
            studentLinkedListD.AddFirst(student2);
            LinkedListNode<Student> Head = studentLinkedListD.Head;

            Assert.Equal(student2,Head.Value);

        }

        [Fact]
        public void DoubleinkedListTail()
        {
            studentLinkedListD = new DoubleLinkedList<Student>();
            studentLinkedListD.AddFirst(student8);
            studentLinkedListD.AddLast(student2);
            LinkedListNode<Student> Tail = studentLinkedListD.Tail;

            Assert.Equal(student2, Tail.Value);
        }

        [Fact]
        public void DoubleLinkedListContains()
        {
            studentLinkedListD = new DoubleLinkedList<Student>();
            studentLinkedListD.AddFirst(student9);
            studentLinkedListD.AddFirst(student7);
            studentLinkedListD.AddFirst(student8);
            bool contains = studentLinkedListD.Contains(student8);
            Assert.True(contains);
        }

        [Fact]
        public void DoubleLinkedListRemove() 
        {
                studentLinkedListD = new DoubleLinkedList<Student>();
                studentLinkedListD.AddFirst(student9);
                studentLinkedListD.AddFirst(student7);
                studentLinkedListD.AddFirst(student6);
                studentLinkedListD.RemoveFirst();
                LinkedListNode<Student> Head = studentLinkedListD.Head; 
                Assert.NotEqual<Student>(student7,Head.Value);
        }


        //Binarytree Tests

        [Fact]
        public void BinaryTreeAdd()
        {
            binaryTreeStudent = new BinaryTree();
            Random rnd = new Random();
            student1.StudentID = rnd.Next(1,40);
            student2.StudentID = rnd.Next(1, 40);
            binaryTreeStudent.Add(student1);
            binaryTreeStudent.Add(student2);

           Node find = binaryTreeStudent.find(student1);

           Assert.Equal(student1.StudentID, find.Data);
        } 

       

        

    }

        
}
