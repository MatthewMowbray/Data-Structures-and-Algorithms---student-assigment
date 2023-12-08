using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms___Assignment
{
    internal class StudentEqualityComparer:EqualityComparer<Student>
    {
        private static readonly StudentEqualityComparer _instance = new StudentEqualityComparer();

        public static StudentEqualityComparer Instance { get { return _instance; } }

        private StudentEqualityComparer()
        {
        }

        public override bool Equals(Student? x, Student? y)
        {
            if (x == null && y == null)
                return true;
            else if (x == null || y == null)
                return false;
            return x.StudentID == y.StudentID && x.DateRegistered.ToUpperInvariant() == y.DateRegistered.ToUpperInvariant() && x.Program.ToUpperInvariant() == y.Program.ToUpperInvariant()
                && x.Enrollment == y.Enrollment;
        
        }

        public override int GetHashCode([DisallowNull] Student obj)
        {
            return obj.Program.ToUpperInvariant().GetHashCode() ^ obj.DateRegistered.GetHashCode();
        }
    }
}
