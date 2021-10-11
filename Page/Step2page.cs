using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UTestAutomation 
{
    class Step2page : BasePage
    {
        
        IWebElement SubTitleStep2 = Driver.FindElement(By.XPath("//span[@class='sub-title']"));

        public void VerifyPageStep2Display(out bool result)
        {
            result = false;
            By XPath = By.XPath("//span[@class='sub-title']");
            WaitForElement(XPath);
            string acctualResult = SubTitleStep2.Text.ToString().Trim();
            string expectedTitle = "Add your address";
            if (SubTitleStep2.Displayed && SubTitleStep2.Text.ToString() == expectedTitle)
                result = true;
        }

    }
}
