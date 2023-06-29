using JustTestITAutomation.Pages;
using JustTestITAutomation.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace JustTestITAutomation.Steps
{
    [Binding]
    class RegisterPageSteps 
    {
        private IWebDriver driver;
        RegisterPage registerPage;
        HomePage homePage;
        public RegisterPageSteps(IWebDriver driver)
        {
            this.driver = driver;
            registerPage = new RegisterPage(driver);
            homePage = new HomePage(driver);
            
        }
        
        [Given(@"I navigate to the registration page")]
        public void GivenINavigateToTheRegistrationPage()
        {
            
           registerPage=homePage.ClickOnRegisterLink();
        }

        [When(@"I  Register with following Data")]
        public void WhenIRegisterWithFollowingData(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            registerPage.EnterRegisterData(data.Email, data.FirstName,
                data.LastName, data.Password, data.ConfirmPassword);
        }

        [Then(@"I should get message ""([^""]*)""")]
        public void ThenIShouldGetMessage(string message)
        {
            string result = registerPage.ValidAlertMessage();
            Assert.True(result.Contains(message));
        }

        [Given(@"I have already registered with following data")]
        public void GivenIHaveAlreadyRegisteredWithFollowingGata(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            registerPage.EnterRegisterData(data.Email, data.FirstName,
                data.LastName, data.Password, data.ConfirmPassword);
        }

        [When(@"I have enter invalid password")]
        public void WhenIHaveEnterInvalidPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            registerPage.EnterRegisterData(data.Email, data.FirstName,
                data.LastName, data.Password, data.ConfirmPassword);
        }







    }
}


