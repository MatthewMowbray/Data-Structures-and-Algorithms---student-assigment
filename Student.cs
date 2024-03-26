using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms___Assignment
{
    public sealed class Student:Person, IComparable<Student>, IEquatable<Student>, IComparable
    {
        public Enrollment Enrollment { get; set;}
        public int StudentID {get;set;}
        public string Program { get; set;}
        public string DateRegistered { get;set;}

        public Student(Enrollment enrollment,int studentid,string program,string datereg, string name,string email,string telnum, Address address):base(name, email, telnum, address)
        {
            Enrollment = enrollment;
            StudentID = studentid;
            Program = program;
            DateRegistered = datereg;
        }
        /// <summary>
        /// Implementation of the comparTo from Icomparable
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(Object? obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));
            if (!(obj is Student))
                throw new ArgumentException("Expected Student instance", "obj");
            return CompareTo((Student)obj);
        }


        /// <summary>
        /// Compares Student Name of two student objects 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Student? other)
        {

            return this.Name.CompareTo(other.Name);
        }


        /// <summary>
        /// Equal overload
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Student? other)
        {
            return StudentID == other.StudentID;
        }


        /// <summary>
        /// Overide of the Equals method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != GetType())
                return false;
            Student? student = obj as Student;
            return this.StudentID == student.StudentID;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Student a, Student b)
        {
            return object.Equals(a, b);
        }

        public static bool operator !=(Student a, Student b)
        {
            return !object.Equals(a, b);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.DateRegistered.GetHashCode() ^ this.Program.GetHashCode() ^ this.StudentID;
        }

        public static bool operator <(Student x, Student y)
        {
            return x.StudentID < y.StudentID;
        }

        public static bool operator <=(Student x, Student y)
        {
            return x.StudentID <= y.StudentID;
        }

        public static bool operator >(Student x, Student y)
        {
            return x.StudentID > y.StudentID;
        }

        public static bool operator >=(Student x, Student y)
        {
            return x.StudentID >= y.StudentID;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Student ID: {StudentID}");
            sb.AppendLine($"Program: {Program}");
            sb.AppendLine($"DateRegistered: {DateRegistered}");
            sb.AppendLine("Enrollment Info:");
            sb.AppendLine($"{Enrollment.ToString()}");
            return sb.ToString();
        }

    }
}
