using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms___Assignment
{
    public class Address
    {
        private static int NUMBER = 0;
        private static string STREET = "N/A";
        private static string SUBURB = "N/A";
        private static string POSTCODE = "N/A";
        private static string STATE = "SA";



        public int Number { get;set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        public Address()
        {
            Number = NUMBER;
            Street = STREET;
            Suburb = SUBURB;
            Postcode = POSTCODE;
            State = STATE;
        }


        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != GetType())
                return false;
            Address? address = obj as Address;
            return this.Number == address.Number  && this.Street == address.Street &&   this.Suburb == address.Suburb  &&       
                   this.Postcode == address.Postcode && this.State == address.State;

        }

        public static bool operator ==(Address? a, Address? b)
        {
            return object.Equals(a, b);
        }

        public static bool operator !=(Address? a, Address? b)
        {
            return !object.Equals(a, b);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
