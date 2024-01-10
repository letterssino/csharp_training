using NUnit.Framework;


namespace adressbook_web_test_Unit
{
    [TestFixture]
    public class UserCreationTests : TestBase
    {

        [Test]
        public void UserCreationTest()
        {
            app.NavigationHelper.Openhomepage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.UserHelper.InitUserCreation();
            ContactData contact = new ContactData("firstname");
            contact.Middlename = "middlename";
            contact.Lastname = "Lastname";
            contact.Bmonth = "November";
            contact.New_group = "[none]";
            app.UserHelper.FillUserForm(contact);
            app.UserHelper.SubmitUserCreation();
            app.Auth.Logout();
        }
    }
}
