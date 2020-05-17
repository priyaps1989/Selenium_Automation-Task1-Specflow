using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Mars.Steps
{
    [Binding]
    public  class BaseHook
    {
        public  IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://192.168.99.100:5000/Home");
            TestContext.WriteLine("BeforeScenario");

        }
        
        [AfterScenario]
        public void AfterScenario()
        {
            TestContext.WriteLine("AfterScenario");
            driver.Quit();
        }
    }
}
