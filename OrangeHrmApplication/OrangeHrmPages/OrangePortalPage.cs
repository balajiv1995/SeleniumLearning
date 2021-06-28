using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHrmApplication.OrangeHrmPages
{
    class OrangePortalPage
    {

        public static By profileIconLocator = By.Id("welcome");
        public static By aboutLocator = By.LinkText("About");
        public static By companyinfoLocator = By.Id("companyInfo");
        private static void ClickonDashboardMenu()
        { 
        
        
        }

        private static void ClickonMyInfoMenu()
        {


        }

        public static void ClickonProfileIcon(IWebDriver driver)
        {
            driver.FindElement(profileIconLocator).Click();
            driver.FindElement(aboutLocator).Click();
            string companyinfo = driver.FindElement(companyinfoLocator).Text;
            Assert.True(companyinfo.Contains("BTG Knitwear Ltd"));
            Assert.True(companyinfo.Contains("Version: Orangehrm OS 4.8"));

        }

        


        // Tab/Menu Handle
    }
}
