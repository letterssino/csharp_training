using OpenQA.Selenium;
using System;

namespace adressbook_web_test_Unit
{
    public class NavigationHelper : HelperBase
    {
        
        private string baseURL;
        
        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
        }
        public void ReturnToGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }

        public void GoToGroupPage()
        {
            if (driver.Url == baseURL + "/group.php"
                && IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }

        public void Openhomepage()
        {
            if (driver.Url == baseURL)
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL);
        }

        public void InitUserCreation()
        {
            if (driver.Url == baseURL + "/edit.php")
            {
                return;
            }
            driver.FindElement(By.LinkText("add new")).Click();
        }

    }
}
