using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UTestAutomation 
{
    class Homepage : DriverHelper
    {
        IWebElement BtnJoinToday = Driver.FindElement(By.XPath("//ul[@class='nav navbar-nav']//a[@href='/signup/personal']"));

        public void SelectJoinTodayButton()
        {
            BtnJoinToday.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
    }
}
