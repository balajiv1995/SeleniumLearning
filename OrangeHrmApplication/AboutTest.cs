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
    class AboutTest : WebdriverWrapper
    {
        IWebDriver driver;

        [SetUp]
        //Browser launch
        public void OrangeSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [TearDown]
        //Browser Close
        public void OrangeTeardown()
        {
            driver.Quit();
            //driver.Dispose();
        }


        [Test]
        public void AboutSectionTest()
        {

            LoginPage.EnterUsername(driver,"Admin");
            LoginPage.Enterpassword(driver,"admin123");
            LoginPage.Clickogin(driver);

            OrangePortalPage.ClickonProfileIcon(driver);

            //Assertion or Validation with Assert.true and contains
            



        }


    }
}
