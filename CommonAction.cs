using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace UTestAutomation
{
    public class CommonAction : BasePage
    {
        public static void SelectDropdownListValue(IWebElement dropDownList, string selectValue)
        {
            var listId = dropDownList.GetAttribute("id");
            IWebElement liOption = Driver.FindElement(By.XPath($"//Select[@id='{listId}']/option[text()='{selectValue}']"));
            dropDownList.Click();
            liOption.Click();
        }
    }
}
