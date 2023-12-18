using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressbook_web_test_Unit
{
    public class UserData
    {
        private string firstname;
        private string middlename;
        private string lastname;
        private string nickname;
        private string title;
        private string company;
        private string address;
        private string home;
        private string mobile;
        private string work;
        private string fax;
        private string email;
        private string homepage;
        private int bday;
        private string bmonth;
        private int byear;
        
        public UserData(string firstname)
        { 
            this.firstname = firstname;
        }
    }
    
}
