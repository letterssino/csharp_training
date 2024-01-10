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
        protected ContactHelper userHelper;
        protected string baseURL;
        protected IWebDriver driver;

        public ApplicationManager()
        {
            baseURL = "http://localhost/addressbook/";
            driver = new ChromeDriver();
            loginHelper = new LoginHelper(driver);
            navigationHelper = new NavigationHelper(driver, baseURL);
            groupHelper = new GroupHelper(driver);
            userHelper = new ContactHelper(driver);
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
        
        public ContactHelper UserHelper
        {
            get { return userHelper; } 
        }

        public string BaseURL
        { get { return baseURL; } } 
    }
}
