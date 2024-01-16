using NUnit.Framework;


namespace adressbook_web_test_Unit
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {

        [Test]
        public void UserCreationTest()
        {
         
            ContactData contact = new ContactData("firstname");
            contact.Middlename = "middlename";
            contact.Lastname = "Lastname";
            contact.Bmonth = "November";
            contact.New_group = "[none]";

            app.ContactHelper.ContacCreat(contact);
        }
    }
}
