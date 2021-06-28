using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHrmApplication.OrangeHrmBase
{
    class WebdriverWrapper
    {

        //Driver object creation
        protected IWebDriver driver;

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
    }
}
