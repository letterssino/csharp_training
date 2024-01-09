using NUnit.Framework;

namespace adressbook_web_test_Unit
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
 

        [Test]
        public void GroupCreationTest()
        {
            Openhomepage();
            Login(new AccountData("admin","secret"));
            GoToGroupPage();
            InitGroupCreation();
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "sss";
            FillGroupForm(group);
            
            SubmitGroupCreation();
            ReturnToGroupPage();
            Logout();
        }
    }
}
