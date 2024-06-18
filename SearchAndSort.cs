using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms___Assignment
{
   public static  class SearchAndSort<T>where T : IComparable<T>
    {
        /// <summary>
        /// Performs a linear search looking for a student within an array of students
        /// </summary>
        /// <param name="studentArray"></param>
        /// <param name="student"></param>
        /// <returns>Index of student</returns>
       public static int LinearSearchOfStudent(T[] array, T searchTarget)
        {
            int i = 0;
            bool found = false;

            try
            {
                while (!found && i < array.Length)
                {
                    if (searchTarget.Equals(array[i]))
                        found = true;
                    else
                        i++;

                }
                if (i < array.Length)
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
      public  static int BinarySearchOfStudent(T[] array, T searchTarget)
        {
            int min = 0;
            int max = array.Length - 1;
            int mid;
            try
            {
                do
                {
                    mid = (max + min) / 2;
                    if (array[mid].Equals(searchTarget))
                        return mid;

                    if (searchTarget.CompareTo(array[mid]) > 0)
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
      public  static void BubbleSortOfStudentAsc(T[] array)
        {
            T temp;
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = j+1; i < array.Length - 1; i++)
                {
                    if (array[j].CompareTo(array[i]) > 0)
                    {   //swap the numbers
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// Implements bubble sort, sorting names in descending order
        /// </summary>
        /// <param name="studentArray"></param>
     public  static void BubbleSortOfStudentDes(T[] array)
        {
            T temp;
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = j+1; i < array.Length - 1; i++)
                {
                    if (array[j].CompareTo(array[i]) < 0)
                    {   //swap the numbers
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// Implementation of selection sort for student objects by student ID
        /// </summary>
        /// <param name="studentArray"></param>
      public  static void SelectionSortOfStudent(T[] array)
        {
            T temp;
            int minIndex;
            for (int i = 0; i < array.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                        minIndex = j;
                }
                //swap
                temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
 

     
    }
}
