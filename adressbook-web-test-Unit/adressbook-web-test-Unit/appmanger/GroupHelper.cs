﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressbook_web_test_Unit
{
    public class GroupHelper : HelperBase
    {
        

        public GroupHelper(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        public void SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        public void FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }

        public void InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }
        public void RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
        }

        public void SelectGroup(int index)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/span[" + index + "]/input")).Click();
        }
    }
}
