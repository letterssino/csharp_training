using adressbook_web_test_Unit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressbook_web_test_Unit
{
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newContactData = new ContactData("Test");
            newContactData.Middlename = "Test";
            newContactData.Lastname = "Test";
            newContactData.Bday = "20";
            newContactData.Byear = "1995";
            newContactData.Bmonth = "December";
            app.ContactHelper.ContactModification(1, newContactData);
        }
    }
}
