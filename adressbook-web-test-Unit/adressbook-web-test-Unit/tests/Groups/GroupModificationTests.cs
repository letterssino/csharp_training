using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressbook_web_test_Unit
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]

        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("zzz");
            newData.Header = null;
            newData.Footer = null;
            app.GroupHelper.Modify(1, newData);
        }
    }
}
