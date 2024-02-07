using adressbook_web_test_Unit;
using NUnit.Framework;
using System.Collections.Generic;

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

            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();

            app.GroupHelper.CreateGroup(group);

            List<GroupData> newGroups = app.GroupHelper.GetGroupList();
            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {         
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();

            app.GroupHelper.CreateGroup(group);

            List<GroupData> newGroups = app.GroupHelper.GetGroupList();
            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
        }
    }
}
