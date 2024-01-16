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
            driver.FindElement(By.LinkText("groups")).Click();
        }

        public void Openhomepage() // переход на базовую страницу
        {
            driver.Navigate().GoToUrl(baseURL);
        }

        public void InitUserCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

    }
}
