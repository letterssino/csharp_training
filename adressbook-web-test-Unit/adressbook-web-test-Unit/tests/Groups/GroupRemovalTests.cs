using adressbook_web_test_Unit;
using NUnit.Framework;

namespace adressbook_web_test_Unit
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            
            app.GroupHelper.RemovalGroup(1);
        }
    }
}
