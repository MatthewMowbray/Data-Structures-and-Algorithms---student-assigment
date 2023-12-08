using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms___Assignment
{
    public class Course: IComparable<Course>, IEquatable<Course>, IComparable
    {
        public int CourseCode { get; set; }
        public string CourseName{get;set;}
        public double Cost{get;set; }

        public Course(int coursecode,string coursename,double cost)
        {
            CourseCode = coursecode;
            CourseName = coursename;
            Cost = cost;
        }


        public int CompareTo(Object? obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));
            if (!(obj is Course))
                throw new ArgumentException("Expected Course instance", "obj");
            return CompareTo((Course)obj);
        }



        public int CompareTo(Course? other)
        {

            return this.CourseCode.CompareTo(other.CourseCode);
        }



        public bool Equals(Course? other)
        {
            return CourseCode == other.CourseCode;
        }


        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != GetType())
                return false;
            Course? course = obj as Course;
            return this.CourseCode == course.CourseCode && this.CourseName == course.CourseName && this.Cost == course.Cost;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CourseName, Cost);
        }

        public static bool operator ==(Course a, Course b)
        {
            return object.Equals(a, b);
        }

        public static bool operator !=(Course a, Course b)
        {
            return !object.Equals(a, b);
        }

        public static bool operator <(Course x, Course y)
        {
            return x.CourseCode < y.CourseCode;
        }

        public static bool operator <=(Course x, Course y)
        {
            return x.CourseCode <= y.CourseCode;
        }

        public static bool operator >(Course x, Course y)
        {
            return x.CourseCode > y.CourseCode;
        }

        public static bool operator >=(Course x, Course y)
        {
            return x.CourseCode >= y.CourseCode;
        }

    }
}
