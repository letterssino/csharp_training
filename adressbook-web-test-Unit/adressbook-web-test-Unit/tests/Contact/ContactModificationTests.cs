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
            app.ContactHelper.CheckNullContactList();
            ContactData newContactData = new ContactData("Test");
            newContactData.Middlename = "Test";
            newContactData.Lastname = "Test";
            newContactData.Bday = "20";
            newContactData.Byear = "1995";
            newContactData.Bmonth = "December";

            List<ContactData> oldContacts = app.ContactHelper.GetContactList();

            app.ContactHelper.ContactModification(0, newContactData);

            List<ContactData> newContacts = app.ContactHelper.GetContactList();

            oldContacts[0].Firstname = oldContacts[0].Firstname + newContactData.Firstname;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
