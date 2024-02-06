﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressbook_web_test_Unit
{
    [TestFixture]
    public class LoginTest : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            // prepare
            app.NavigationHelper.Openhomepage();
            app.Auth.Logout();

            //action
            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login(account);

            // verification
            Assert.IsTrue(app.Auth.IsLoggedIn(account));
        }

        [Test]
        public void LoginWithInValidCredentials()
        {
            // prepare
            app.NavigationHelper.Openhomepage();
            app.Auth.Logout();

            //action
            AccountData account = new AccountData("admin", "123456");
            app.Auth.Login(account);

            // verification
            Assert.IsFalse(app.Auth.IsLoggedIn(account));
        }
    }
}