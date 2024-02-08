using adressbook_web_test_Unit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressbook_web_test_Unit
{
    public class ContactDeletedTests : AuthTestBase
    {
        [Test]
        public void ContactDeletedTest() 
        {
            app.ContactHelper.CheckNullContactList();

            List<ContactData> oldContacts = app.ContactHelper.GetContactList();
            System.Console.WriteLine(oldContacts.Count);

            app.ContactHelper.ContactDeleted(1);

            List<ContactData> newContacts = app.ContactHelper.GetContactList();
            Assert.AreEqual(oldContacts.Count -1 , newContacts.Count);
        }

    }
}
