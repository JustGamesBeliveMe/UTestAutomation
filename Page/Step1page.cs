using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace UTestAutomation 
{
    class Step1page : BasePage
    {
        
        IWebElement TxtUserName     = Driver.FindElement(By.Id("firstName"));
        IWebElement TxtLastName     = Driver.FindElement(By.Id("lastName"));
        IWebElement TxtEmail        = Driver.FindElement(By.Id("email"));
        IWebElement DdlBirthMonth   = Driver.FindElement(By.Id("birthMonth"));
        IWebElement DdlBirthDay     = Driver.FindElement(By.Id("birthDay"));
        IWebElement DdlBirthYear    = Driver.FindElement(By.Id("birthYear"));
        IWebElement BtnNextStep     = Driver.FindElement(By.XPath("//*[@role='button']"));
        IWebElement ErrorMessage    = Driver.FindElement(By.Id("emailError"));
        
        public void EnterUserDetails()
        {
            //Enter username
            TxtUserName.Clear();
            TxtUserName.SendKeys("Auto firstName");
            //Enter lastName
            TxtLastName.Clear();
            TxtLastName.SendKeys("Auto lastName");
            //Enter email:
            TxtEmail.Clear();
            TxtEmail.SendKeys("AutoEmail@test.com");
            //Select month
            CommonAction.SelectDropdownListValue(DdlBirthMonth, "May");
            //Select day
            CommonAction.SelectDropdownListValue(DdlBirthDay, "21");
            //Select year
            CommonAction.SelectDropdownListValue(DdlBirthYear, "2000");

        }
        public void EnterInvalidEmail()
        {
            TxtEmail.Clear();
            TxtEmail.SendKeys("Auto Invalid");
        }
        public void ClickNextStepButton()
        {
            BtnNextStep.Click();
        }
        public void VerifyErrorMessageDisplay(out bool result)
        {
            By Id = By.Id("emailError");
            WaitForElement(Id);
            string errorMessage = "Enter valid email";
            result = false;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            if (ErrorMessage.Displayed && ErrorMessage.Text.ToString().Trim() == errorMessage)
            result = true;
        }
    }
}
