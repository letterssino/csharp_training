using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace adressbook_web_test_Unit
{
    public class ApplicationManager
    {
        protected string baseURL;
        protected IWebDriver driver;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;
        

        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        private ApplicationManager()
        {
            baseURL = "http://localhost/addressbook";
            driver = new ChromeDriver();

            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
        }

        ~ApplicationManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public static ApplicationManager GetInstance()
        {
            if (! app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.NavigationHelper.Openhomepage();
                app.Value = newInstance;
                
                
            }
            return app.Value;
        }
        public IWebDriver Driver 
        {
            get { return driver; }
        }
       
        public LoginHelper Auth
        {
            get { return loginHelper; }
        }

        public NavigationHelper NavigationHelper
        {
            get { return navigationHelper; }
        }

        public GroupHelper GroupHelper
        {
            get { return groupHelper; }
        }
        
        public ContactHelper ContactHelper
        {
            get { return contactHelper; } 
        }

        public string BaseURL
        { get { return baseURL; } }

    }
}
