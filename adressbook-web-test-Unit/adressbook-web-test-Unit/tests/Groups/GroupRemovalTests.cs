using adressbook_web_test_Unit;
using NUnit.Framework;
using System.Collections.Generic;

namespace adressbook_web_test_Unit
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            app.GroupHelper.CheckNullGroupList();
            
            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();

            app.GroupHelper.RemovalGroup(0);

            List<GroupData> newGroups = app.GroupHelper.GetGroupList();

            oldGroups.RemoveAt(0);
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
