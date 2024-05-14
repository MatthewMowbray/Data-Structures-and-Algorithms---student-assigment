using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms___Assignment
{
   public  static class SearchAndSort
    {
        /// <summary>
        /// Performs a linear search looking for a student within an array of students
        /// </summary>
        /// <param name="studentArray"></param>
        /// <param name="student"></param>
        /// <returns>Index of student</returns>
       public static int LinearSearchOfStudent(Student[] studentArray, Student student)
        {
            int i = 0;
            bool found = false;

            try
            {
                while (!found && i < studentArray.Length)
                {
                    if (student.Equals(studentArray[i]))
                        found = true;
                    else
                        i++;

                }
                if (i < studentArray.Length)
                    return i;
                else
                    return -1;

            }

            catch
            {
                throw new NullReferenceException("Student must not be null");
            }
       
        
            
            
        }
        
        /// <summary>
        /// Peforms a binary search on an array of student
        /// </summary>
        /// <param name="studentArray"></param>
        /// <param name="student"></param>
        /// <returns>Index of student</returns>
      public  static int BinarySearchOfStudent(Student[] studentArray, Student student)
        {
            int min = 0;
            int max = studentArray.Length - 1;
            int mid;
            try
            {
                do
                {
                    mid = (max + min) / 2;
                    if (studentArray[mid].Equals(student))
                        return mid;

                    if (student.CompareTo(studentArray[mid]) > 0)
                        min = mid + 1;

                    else
                        max = mid - 1;

                } while (min <= max);
                return -1;
            }
            catch
            {
                throw new  NullReferenceException("Student must not be null");
            }
         

        }
        /// <summary>
        /// Implements bubble sort, sorting names in ascending order
        /// </summary>
        /// <param name="studentArray"></param>
      public  static void BubbleSortOfStudentAsc(Student[] studentArray)
        {
            Student temp;
            for (int j = 0; j < studentArray.Length - 1; j++)
            {
                for (int i = j+1; i < studentArray.Length - 1; i++)
                {
                    if (studentArray[j].CompareTo(studentArray[i]) > 0)
                    {   //swap the numbers
                        temp = studentArray[j];
                        studentArray[j] = studentArray[i];
                        studentArray[i] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// Implements bubble sort, sorting names in descending order
        /// </summary>
        /// <param name="studentArray"></param>
     public  static void BubbleSortOfStudentDes(Student[] studentArray)
        {
            Student temp;
            for (int j = 0; j < studentArray.Length - 1; j++)
            {
                for (int i = j+1; i < studentArray.Length - 1; i++)
                {
                    if (studentArray[j].Name.CompareTo(studentArray[i].Name) < 0)
                    {   //swap the numbers
                        temp = studentArray[j];
                        studentArray[j] = studentArray[i];
                        studentArray[i] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// Implementation of selection sort for student objects by student ID
        /// </summary>
        /// <param name="studentArray"></param>
      public  static void SelectionSortOfStudent(Student[] studentArray)
        {
            Student temp;
            int minIndex;
            for (int i = 0; i < studentArray.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < studentArray.Length; j++)
                {
                    if (studentArray[j] < studentArray[minIndex])
                        minIndex = j;
                }
                //swap
                temp = studentArray[minIndex];
                studentArray[minIndex] = studentArray[i];
                studentArray[i] = temp;
            }
        }
        /// <summary>
        /// Implementation of insertionsort, sorts by  studentID 
        /// </summary>
        /// <param name="studentArray"></param>
       public static void InsertionSort(Student[] studentArray)
        {
            int n = studentArray.Length;
            for (int i = 1; i < n; ++i)
            {
                Student key = studentArray[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && studentArray[j] > key)
                {
                    studentArray[j + 1] = studentArray[j];
                    j = j - 1;
                }
                studentArray[j + 1] = key;
            }
        }


    }
}
