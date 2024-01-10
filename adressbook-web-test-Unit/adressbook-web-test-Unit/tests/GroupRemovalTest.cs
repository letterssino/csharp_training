using NUnit.Framework;

namespace adressbook_web_test_Unit
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            app.NavigationHelper.Openhomepage();
            app.Auth.Login(new AccountData("admin","secret"));
            app.NavigationHelper.GoToGroupPage();
            app.GroupHelper.SelectGroup(1);
            app.GroupHelper.RemoveGroup();
            app.NavigationHelper.ReturnToGroupsPage();
            app.Auth.Logout();
        }
    }
}
