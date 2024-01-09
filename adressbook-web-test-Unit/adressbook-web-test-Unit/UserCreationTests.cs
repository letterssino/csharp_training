using NUnit.Framework;


namespace adressbook_web_test_Unit
{
    [TestFixture]
    public class UserCreationTests : TestBase
    {

        [Test]
        public void UserCreationTest()
        {
            Openhomepage();
            Login(new AccountData("admin", "secret"));
            InitUserCreation();
            ContactData contact = new ContactData("firstname");
            contact.Middlename = "middlename";
            contact.Lastname = "Lastname";
            contact.Bmonth = "November";
            contact.New_group = "[none]";
            FillUserForm(contact);
            SubmitUserCreation();
            Logout();
        }
    }
}
