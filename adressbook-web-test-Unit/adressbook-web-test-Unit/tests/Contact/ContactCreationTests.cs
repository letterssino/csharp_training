using adressbook_web_test_Unit;
using NUnit.Framework;
using System;
using System.Collections.Generic;


namespace adressbook_web_test_Unit
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {

        [Test]
        public void UserCreationTest()
        {
         
            ContactData contact = new ContactData("firstname");
            contact.Middlename = "middlename";
            contact.Lastname = "Lastname";
            contact.Bmonth = "November";

            List<ContactData> oldContacts = app.ContactHelper.GetContactList();

            app.ContactHelper.ContactCreat(contact);

            Assert.AreEqual(oldContacts.Count + 1, app.ContactHelper.GetContactCount());

            List<ContactData> newContacts = app.ContactHelper.GetContactList();
            oldContacts.Add(contact);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
