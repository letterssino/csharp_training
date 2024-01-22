using NUnit.Framework;

namespace adressbook_web_test_Unit
{
    public class TestBase
    {


        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            app = TestSuiteFixture.app;
            
        }

    }
}
