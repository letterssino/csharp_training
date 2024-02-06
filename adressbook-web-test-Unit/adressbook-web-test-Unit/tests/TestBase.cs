using NUnit.Framework;

namespace adressbook_web_test_Unit
{
    public class TestBase
    {


        protected ApplicationManager app;

        [OneTimeSetUp]
        public void SetupApplicationManager()
        {
            app = ApplicationManager.GetInstance();

        }

    }
}
