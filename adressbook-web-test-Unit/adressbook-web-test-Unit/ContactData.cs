using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressbook_web_test_Unit
{
    public class ContactData
    {
        private string firstname;
        private string middlename = "";
        private string lastname = "";
        private string nickname = "";
        private string title = "";
        private string company = "";
        private string address = "";
        private string home = "";
        private string mobile = "";
        private string work = "";
        private string fax = "";
        private string email = "";
        private string homepage = "";
        private string bday = "";
        private string bmonth = "";
        private string byear = "";
        private string new_group = "";

        public ContactData(string firstname)
        {
            this.firstname = firstname;
        }
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Middlename
        { 
            get { return middlename; }
            set { middlename = value; }
        }
        public string Lastname
        { 
            get { return lastname; }
            set { lastname = value; }
        }

        public string Nickname
        { 
            get { return nickname; }
            set { nickname = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Home
        {
            get { return home; }
            set { home = value; }
        }
        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        public string Work
        {
            get { return work; }
            set { work = value; }
        }
        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Homepage
        {
            get { return homepage; }
            set { homepage = value; }
        }
        public string Bday
        {
            get { return bday; }
            set { bday = value; }
        }
        public string Bmonth
        {
            get { return bmonth; }
            set { bmonth = value; }
        }
        public string Byear
        {
            get { return byear; }
            set { byear = value; }
        }
        public string New_group
        {
            get { return new_group; }
            set { new_group = value; }
        }
    }

}
