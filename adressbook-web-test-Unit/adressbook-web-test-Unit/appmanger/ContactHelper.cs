using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Interfaces;
using System.Reflection.Emit;

namespace adressbook_web_test_Unit
{
    public class ContactHelper : HelperBase
    {


        public ContactHelper(ApplicationManager manager) : base(manager)
        {

        }

        public ContactHelper ContactCreat(ContactData contact)
        {
            manager.NavigationHelper.InitUserCreation();
            FillUserForm(contact);
            SubmitUserCreation();
            
            return this;
        }

        public ContactHelper ContactDeleted(int index) 
        {
            manager.NavigationHelper.Openhomepage();
            ContactSelected(index);
            SubmitContactDeleted();
            
            return this;
        }

        public ContactHelper ContactModification(int index, ContactData newContactData)
        {
            manager.NavigationHelper.Openhomepage();
            FillContactModificationForm(index);
            FillUserForm(newContactData);
            SubmitContactModification();
            return this;
        }



        public ContactHelper FillUserForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("middlename"), contact.Middlename);
            Type(By.Name("lastname"), contact.Lastname);
            Type(By.Name("nickname"), contact.Nickname);
            Type(By.Name("title"), contact.Title);
            Type(By.Name("company"), contact.Company);
            Type(By.Name("address"), contact.Address);
            Type(By.Name("home"), contact.Home);
            Type(By.Name("mobile"), contact.Mobile);
            Type(By.Name("work"), contact.Work);
            Type(By.Name("fax"), contact.Fax);
            Type(By.Name("email"), contact.Email);
            Type(By.Name("homepage"), contact.Homepage);
            TypeSelected(By.Name("bday"), contact.Bday);
            TypeSelected(By.Name("bmonth"), contact.Bmonth);
            Type(By.Name("byear"), contact.Byear);
            /*TypeSelected(By.Name("new_group"), contact.New_group);*/
            return this;
        }

        public ContactHelper SubmitUserCreation()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[20]")).Click();
            return this;
        }

        public ContactHelper ContactSelected(int index)
        {
            driver.FindElement(By.XPath($"/ html / body / div[1] / div[4] / form[2] / table / tbody / tr[{index + 1}] / td[1] / input")).Click();
            //driver.FindElement(By.Id(Convert.ToString(index))).Click(); сделано выделение элемента по порядку.
            return this;
        }

        public ContactHelper SubmitContactDeleted()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.XPath("//input[@name='update']")).Click();
            return this;
        }

        public ContactHelper FillContactModificationForm(int index)
        {
            driver.FindElement(By.XPath($"/ html / body / div[1] / div[4] / form[2] / table / tbody / tr[{index + 1}] / td[8] / a")).Click();
            //driver.FindElement(By.XPath($"//a[@href=\"edit.php?id={index}\"]")).Click(); сделан выбор элемента по порядку, исключая индефикатор.
            return this;
        }
      
    }
}


    