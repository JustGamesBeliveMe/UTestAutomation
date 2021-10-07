using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UTestAutomation 
{
    class Step2page : DriverHelper
    {
        
        IWebElement SubTitleStep2 = Driver.FindElement(By.XPath("//span[@class='sub-title']"));

        public void VerifyPageStep2Display(out bool result)
        {
            result = false;
            string expectedTitle = "Add your address";
            if (SubTitleStep2.Displayed && SubTitleStep2.Text.ToString() == expectedTitle)
                result = true;
        }

    }
}
