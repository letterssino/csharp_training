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

            app.GroupHelper.RemovalGroup(1);

            List<GroupData> newGroups = app.GroupHelper.GetGroupList();
            Assert.AreEqual(oldGroups.Count - 1, newGroups.Count);
        }
    }
}
