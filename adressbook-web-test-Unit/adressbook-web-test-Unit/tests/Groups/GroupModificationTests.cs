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
            app.GroupHelper.Modify(0, newData);
        }
    }
}
