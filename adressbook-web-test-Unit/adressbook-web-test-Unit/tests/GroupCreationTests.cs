using NUnit.Framework;

namespace adressbook_web_test_Unit
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
 

        [Test]
        public void GroupCreationTest()
        {
            app.NavigationHelper.Openhomepage();
            app.Auth.Login(new AccountData("admin","secret"));
            app.NavigationHelper.GoToGroupPage();
            app.Groups.InitGroupCreation();
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "sss";
            app.Groups.FillGroupForm(group);

            app.Groups.SubmitGroupCreation();
            app.NavigationHelper.ReturnToGroupPage();
            app.Auth.Logout();
        }
    }
}
