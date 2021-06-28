using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHrmApplication.OrangeHrmPages
{
    class DashboardPage

        { 
        private static By gettextLocator = By.XPath("//legend[contains(text(),'Distribution')]");
        public static String GetEmployeeDistributionbySubUnitHeader(IWebDriver driver)
        {
            String actualValue = driver.FindElement(gettextLocator).Text;
            return actualValue;
        }

        public static void ClickonMyLeaves()
        { 
        }
    }
}
