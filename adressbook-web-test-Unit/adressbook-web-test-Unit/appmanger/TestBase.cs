using NUnit.Framework;

namespace adressbook_web_test_Unit
{
    public class TestBase
    {


        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();
            app.NavigationHelper.Openhomepage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }


        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }
    }
}
