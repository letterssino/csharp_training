using adressbook_web_test_Unit;
using NUnit.Framework;


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

            app.ContactHelper.ContactCreat(contact);
        }
    }
}
