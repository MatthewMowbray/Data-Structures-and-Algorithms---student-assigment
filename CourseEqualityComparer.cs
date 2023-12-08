using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms___Assignment
{
    internal class CourseEqualityComparer : EqualityComparer<Course>
    {

        private static readonly CourseEqualityComparer _instance = new CourseEqualityComparer();

        public static CourseEqualityComparer Instance { get { return _instance; } }

        private CourseEqualityComparer()
        {
        }
   
        public override bool Equals(Course? x, Course? y)
        {
            if (x == null && y == null)
                return true;
            else if (x == null || y == null)
                return false;
            return x.CourseCode == y.CourseCode && x.CourseName.ToUpperInvariant() == y.CourseName.ToUpperInvariant() && x.Cost == y.Cost;
            
        }

        public override int GetHashCode([DisallowNull] Course obj)
        {
            return obj.CourseName.ToUpperInvariant().GetHashCode() ^ obj.CourseCode.GetHashCode();
        }
    }

}

