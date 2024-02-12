using adressbook_web_test_Unit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace adressbook_web_test_Unit
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]

        public void GroupModificationTest()
        {
            app.GroupHelper.CheckNullGroupList();
            GroupData newData = new GroupData("zzz");
            newData.Header = null;
            newData.Footer = null;
            
            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();

            GroupData oldData = oldGroups[0];
            app.GroupHelper.Modify(0, newData);

            Assert.AreEqual(oldGroups.Count, app.GroupHelper.GetGroupCount());

            List<GroupData> newGroups = app.GroupHelper.GetGroupList();
            oldGroups[0].Name = oldGroups[0].Name + newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

            foreach (GroupData group in newGroups)
            {
                if (group.ID == oldData.ID)
                {
                    Assert.AreEqual(newData.Name , group.Name);
                }
            }
        }
    }
}
