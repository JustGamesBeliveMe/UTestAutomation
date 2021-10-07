using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UTestAutomation
{
    public class FunctionalTests : DriverHelper
    {
        //public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        [Test]
        public void VerifyUserCanRegristerStep1()
        {
            //Given user is logged in web
            string url = "https://www.utest.com/";
            Driver.Navigate().GoToUrl(url);

            //When user navigate to register page
            Homepage home = new Homepage();
            home.SelectJoinTodayButton();

            //And fill all require field
            Step1page step1 = new Step1page();
            step1.EnterUserDetails();

            //And click submit button
            step1.ClickNextStepButton();

            //Then user can see step 2 
            Step2page step2 = new Step2page();
            step2.VerifyPageStep2Display(out bool result);
            Assert.IsTrue(result);
        }
        [Test]
        public void VerifyInvalidEmailAdressMessageDisplay()
        {
            //Given user is logged in web
            string url = "https://www.utest.com/";
            Driver.Navigate().GoToUrl(url);

            //When user navigate to register page
            Homepage home = new Homepage();
            home.SelectJoinTodayButton();

            //And fill a invalid email adresss
            Step1page step1 = new Step1page();
            step1.EnterInvalidEmail();

            //Then user can see step 2 
            step1.VerifyErrorMessageDisplay(out bool result);
            Assert.IsTrue(result);
        }

        [TearDown]
        public void CloseDriver()
        {
            Driver.Close();
        }
    }
}