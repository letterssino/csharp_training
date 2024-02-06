using adressbook_web_test_Unit;
using NUnit.Framework;

namespace adressbook_web_test_Unit
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
 

        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "sss";

            app.GroupHelper.CreateGroup(group);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {         
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            app.GroupHelper.CreateGroup(group);
        }
    }
}
