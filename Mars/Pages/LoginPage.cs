using Mars.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mars.Pages
{
    class LoginPage
    {

        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

           IWebElement SigninButton => driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
           IWebElement UserName => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
           IWebElement Password=> driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
           IWebElement LoginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        
        public void Login()
        {
            SigninButton.Click();
            
        }
        public void LoginWithCredentials() {
            Login();
            UsernamePassword();
            ClickSubmit();
        }

        public void UsernamePassword()
        {
            Thread.Sleep(2000);
            UserName.SendKeys("emailpriyaps@gmail.com");
            Password.SendKeys("priya@11173");
            
        }

        public void ClickSubmit()
        {
            LoginButton.Click();

        }

        public void ValidateLogin()
        {
            Thread.Sleep(8000);
            //  Assert.That(driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div/div[2]/div/table/thead/tr/th[4]/div")).Displayed);
            Assert.That(driver.FindElement(By.LinkText("Sign Out")).Displayed);
        }
    }
}
