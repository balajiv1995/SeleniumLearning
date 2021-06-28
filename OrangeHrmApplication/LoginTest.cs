using Maveric.OrangeHrmApplication.OrangeHrmPages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OrangeHrmApplication.OrangeHrmBase;
using OrangeHrmApplication.OrangeHrmPages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maveric.OrangeHrmApplication
{
    class LoginTest : WebdriverWrapper
    {

        [Test, Order(1)]
        public void ValidCredentialTest()
        {
            LoginPage.EnterUsername(driver,"Admin");
            //Take "Admin -> username" from Excel
            LoginPage.Enterpassword(driver, "admin123");
            LoginPage.Clickogin(driver);
            string actualValue = DashboardPage.GetEmployeeDistributionbySubUnitHeader(driver);
            Assert.AreEqual("Employee Distribution by SubUnit", actualValue);

        }

        [Test, Order(2)]
        public void InvalidLoginCredentialTest()
        {
            LoginPage.EnterUsername(driver, "Admin");
            LoginPage.Enterpassword(driver, "admin123");
            LoginPage.Clickogin(driver);
            String validationmsg = LoginPage.GetErrorMessage(driver);
            Console.WriteLine(validationmsg);
            Assert.AreEqual("Invalid credentials", validationmsg);
        }
        
        [Test,Order(3)]
        public void EmptyCredentials()
        {
            LoginPage.Clickogin(driver);
            String errormsg1 = LoginPage.GetErrorMessage1(driver);
            Console.WriteLine(errormsg1);
            Assert.AreEqual("Username cannot be empty", errormsg1);

        }

        [Test,Order(4)]
        public void Usernameunentered()
        {
            LoginPage.Enterpassword(driver, "admin123");
            LoginPage.Clickogin(driver);
            String errormsg2 = LoginPage.GetErrorMessage1(driver);
            Console.WriteLine(errormsg2);
            Assert.AreEqual("Username cannot be empty", errormsg2);
        }

        [Test,Order(5)]
        public void Passwordunentered()
        {
            LoginPage.EnterUsername(driver,"Admin");
            LoginPage.Clickogin(driver);
            String errormsg2 = LoginPage.GetErrorMessage2(driver);
            Console.WriteLine(errormsg2);
            Assert.AreEqual("Password cannot be empty", errormsg2);
        }

    }
}
