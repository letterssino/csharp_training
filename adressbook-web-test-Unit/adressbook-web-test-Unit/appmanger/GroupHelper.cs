using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace adressbook_web_test_Unit
{
    public class GroupHelper : HelperBase
    {


        public GroupHelper(ApplicationManager manager) : base(manager)
        {
            
        }

        public GroupHelper CreateGroup(GroupData group)
        {
            manager.NavigationHelper.GoToGroupPage();
            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            return this;
        }

        public GroupHelper Modify(int index, GroupData newData)
        {
            manager.NavigationHelper.GoToGroupPage();
            SelectGroup(index);
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGroupModification();
            ReturnToGroupsPage();

            return this;
        }

 

        public GroupHelper RemovalGroup(int index)
        {
            manager.NavigationHelper.GoToGroupPage();
            SelectGroup(index);
            RemoveGroup();
            ReturnToGroupsPage();
            return this;
        }
        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            groupCashe = null;
            return this;
        }

        public GroupHelper FillGroupForm(GroupData group)
        {
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
            return this;
        }


        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }
        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            groupCashe = null;
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/span[" + (index + 1) + "]/input")).Click();
            return this;
        }
        public  GroupHelper ReturnToGroupsPage()
        {
            if (driver.FindElements(By.LinkText("group page")) == null)
            {
                driver.FindElement(By.LinkText("group page")).Click();
                return this;
            }
            else
            {
                manager.NavigationHelper.GoToGroupPage();
                return this;
            }
            
        }

        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            groupCashe = null;
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        private List<GroupData> groupCashe = null;
        public List<GroupData> GetGroupList()
        {
            if (groupCashe == null)
            {
                groupCashe = new List<GroupData>();
                manager.NavigationHelper.GoToGroupPage();
                ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));
                foreach (IWebElement element in elements)
                {
                    
                    groupCashe.Add(new GroupData(element.Text)
                    {
                        ID = element.FindElement(By.TagName("input")).GetAttribute("value")
                    });
                }
            }
            
            return new List<GroupData>(groupCashe);
        }
        
        public void CheckNullGroupList()
        {
            List<GroupData> oldGroups = GetGroupList();
            if (oldGroups.Count == 0)
            {
                GroupData group = new GroupData("aaa");
                group.Header = "ddd";
                group.Footer = "sss";
                CreateGroup(group);
            }
        }

        public int GetGroupCount()
        {
            return driver.FindElements(By.CssSelector("span.group")).Count;
        }
    }
}
