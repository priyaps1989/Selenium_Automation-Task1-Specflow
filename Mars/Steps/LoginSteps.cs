using Mars.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Mars.Steps
{
    [Binding]
    public class LoginSteps :BaseHook

    {


        LoginPage loginObj;

        [Given(@"is at the homepage")]
        public void GivenIsAtTheHomepage()
        {
            loginObj = new LoginPage(driver);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [Given(@"navigate to the login page")]
        public void GivenNavigateToTheLoginPage()
        {
            
            loginObj.Login();

        }

        [When(@"enter username and password")]
        public void WhenEnterUsernameAndPassword()
        {
            Thread.Sleep(4000);
            loginObj.UsernamePassword();
        }
        
        [When(@"click on the log in button")]
        public void WhenClickOnTheLogInButton()
        {
            Thread.Sleep(4000);
            loginObj.ClickSubmit();
        }

        [Then(@"successfully logged in to the account")]
        public void ThenSuccessfullyLoggedInToTheAccount()
        {
            Thread.Sleep(8000);
            loginObj.ValidateLogin();
        }
    }
}
