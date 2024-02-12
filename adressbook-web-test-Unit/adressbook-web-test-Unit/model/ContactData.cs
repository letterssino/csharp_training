using System;

namespace adressbook_web_test_Unit
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string firstname;

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            
            return Firstname == other.Firstname ;
        }

        public override int GetHashCode()
        {
            return Firstname.GetHashCode();
        }

        public override string ToString()
        {
            return "Firstname = " + Firstname;
        }
        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }

            return Firstname.CompareTo(other.Firstname);
        }

        public ContactData(string firstname)
        {
            this.firstname = firstname;
        }
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Middlename { get; set; }
        public string Lastname { get; set; }

        public string Nickname { get; set; }
        public string Title { get; set; }  
        public string Company { get; set; } 

        public string Address { get; set; }

        public string Home { get; set; }
        public string Mobile { get; set; }
        public string Work { get; set; }
        public string Fax { get; set; }
        public string Email { get;set; }
        public string Homepage { get; set; }
        public string Bday { get; set; }
        public string Bmonth { get; set; }
        public string Byear { get; set; }    
        public string New_group { get; set; }
    }

}
