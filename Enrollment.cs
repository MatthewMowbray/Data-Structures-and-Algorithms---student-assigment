using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms___Assignment
{
    public class Enrollment
    {
        public Course Course { get; set; }
        public string EnrolDate {get;set;}
        public string Grade {get;set;}
        public int Semester { get;set;}

        public Enrollment(string enroldate,string grade, int semester,Course course)
        {
            EnrolDate = enroldate;
            Grade = grade;
            Semester = semester;
            Course = course;
        }


        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != GetType())
                return false;
            Enrollment? enrollment = obj as Enrollment;
            return this.EnrolDate == enrollment.EnrolDate && this.Grade == enrollment.Grade && this.Semester == enrollment.Semester &&
                   this.Course.Equals(enrollment);

        }

        public static bool operator ==(Enrollment? a, Enrollment? b)
        {
            return object.Equals(a, b);
        }

        public static bool operator !=(Enrollment? a, Enrollment? b)
        {
            return !object.Equals(a, b);
        }

        public override int GetHashCode()
        {
            return this.Course.GetHashCode() ^ this.EnrolDate.GetHashCode();
        }
    }
}
