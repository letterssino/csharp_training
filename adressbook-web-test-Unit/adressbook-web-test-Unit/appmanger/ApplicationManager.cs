using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace adressbook_web_test_Unit
{
    public class ApplicationManager
    {
        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;
        protected string baseURL;
        protected IWebDriver driver;

        public ApplicationManager()
        {
            baseURL = "http://localhost/addressbook/";
            driver = new ChromeDriver();
            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
        }

        public IWebDriver Driver 
        {
            get { return driver; }
        }
        public void Stop()
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
