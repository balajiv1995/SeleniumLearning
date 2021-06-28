using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maveric.OrangeHrmApplication.OrangeHrmPages
{
    class LoginPage
    {
        private static By usernameLocator = By.Id("txtUsername");
        private static By passwordLocator = By.Id("txtPassword");
        private static By loginLocator = By.Id("btnLogin");
        private static By errorLocator = By.XPath("//span[text()='Invalid credentials']");
        private static By errormsgLocator1 = By.XPath("//span[text()='Username cannot be empty']");
        private static By errormsgLocator2 = By.XPath("//span[text()='Password cannot be empty']");
        

        public static void EnterUsername(IWebDriver driver, string username)
        {
            driver.FindElement(usernameLocator).SendKeys(username);
        }

        public static void Enterpassword(IWebDriver driver, string password)
        {
            driver.FindElement(passwordLocator).SendKeys(password);
        }

        public static void Clickogin(IWebDriver driver)
        {
            driver.FindElement(loginLocator).Click();

        }

        public static String GetErrorMessage(IWebDriver driver)
        {
            String errormessage = driver.FindElement(errorLocator).Text;
            return errormessage;
        }

        public static String GetErrorMessage1(IWebDriver driver)
        {
            String errormessage1 = driver.FindElement(errormsgLocator1).Text;
            return errormessage1;
        }

        public static String GetErrorMessage2(IWebDriver driver)
        {
            String errormessage2 = driver.FindElement(errormsgLocator2).Text;
            return errormessage2;
        }

    }
}
