using NUnit.Framework;

namespace adressbook_web_test_Unit
{
    public class TestBase
    {


        protected ApplicationManager app;

        private bool acceptNextAlert = true;
        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();
        }


        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }
    }
}
