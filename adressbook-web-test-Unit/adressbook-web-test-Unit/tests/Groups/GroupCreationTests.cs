﻿using adressbook_web_test_Unit;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

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

            Assert.AreEqual(oldGroups.Count +1, app.GroupHelper.GetGroupCount());

            List<GroupData> newGroups = app.GroupHelper.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {         
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();

            app.GroupHelper.CreateGroup(group);

            Assert.AreEqual(oldGroups.Count + 1, app.GroupHelper.GetGroupCount());

            List<GroupData> newGroups = app.GroupHelper.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }

        [Test]
        public void BadNameCreationTest()
        {
            GroupData group = new GroupData("a'a");
            group.Header = "";
            group.Footer = "";

            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();

            app.GroupHelper.CreateGroup(group);

            Assert.AreEqual(oldGroups.Count, app.GroupHelper.GetGroupCount());

            List<GroupData> newGroups = app.GroupHelper.GetGroupList();
            //oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
