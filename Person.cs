using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms___Assignment
{
    public class Person
    {
        private Address _Address;

        

        public string Name {get;set;}

        public string Email { get; set; }

        public string TeleNum {get; set;}

        public Address Address { get {return _Address;} set { _Address = value; } }
       

        public Person(string name, string email, string telenum) 
        {
            Name = name;
            Email = email;
            TeleNum = telenum;
            Address = new Address();
        }


        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != GetType())
                return false;
            Person person = obj as Person;
            return this.Name == person.Name && this.Email == person.Email && this.TeleNum == person.TeleNum
                && this.Address.Equals(person);

        }

        public static bool operator ==(Person a, Person b)
        {
            return object.Equals(a, b);
        }

        public static bool operator !=(Person a, Person b)
        {
            return !object.Equals(a, b);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}
