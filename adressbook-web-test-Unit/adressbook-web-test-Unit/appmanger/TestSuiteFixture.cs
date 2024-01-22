using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressbook_web_test_Unit
{
    [SetUpFixture]
    public class TestSuiteFixture
    {
        public static ApplicationManager app;
        [OneTimeSetUp]
        public void initApplicationManger()
        {
            app = new ApplicationManager();
            app.NavigationHelper.Openhomepage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

        [OneTimeTearDown]
        public void StopApplicationManager()
        {
            app.Stop();
        }
    }
}
