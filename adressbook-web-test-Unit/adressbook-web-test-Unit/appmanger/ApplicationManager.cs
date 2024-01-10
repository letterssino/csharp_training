using OpenQA.Selenium;
using System;

namespace adressbook_web_test_Unit
{
    public class ApplicationManager
    {
        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected UserHelper userHelper;
        protected string baseURL;
        protected IWebDriver driver;

        public ApplicationManager()
        {
            loginHelper = new LoginHelper(driver);
            navigationHelper = new NavigationHelper(driver, baseURL);
            groupHelper = new GroupHelper(driver);
            userHelper = new UserHelper(driver);
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

        public GroupHelper Groups
        {
            get { return Groups; }
        }
        
        public UserHelper Users
        {
            get { return Users; } 
        }

        public string BaseURL
        { get { return baseURL; } } 
    }
}
