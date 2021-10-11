using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace UTestAutomation
{
    public class BasePage
    {
        public static IWebDriver Driver { get; set; }
        public static WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        public static void WaitForElement(By by)
        {
            WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }
    }
}
