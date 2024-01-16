using NUnit.Framework;

namespace adressbook_web_test_Unit
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            
            app.GroupHelper.RemovalGroup(1);
        }
    }
}
