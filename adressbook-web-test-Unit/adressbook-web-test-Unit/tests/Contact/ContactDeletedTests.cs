﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressbook_web_test_Unit
{
    public class ContactDeletedTests : TestBase
    {
        [Test]
        public void ContactDeletedTest() 
        {
            
            app.ContactHelper.ContactDeleted(1);

        }

    }
}
