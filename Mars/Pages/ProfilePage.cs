using Mars.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mars.Pages
{
    class ProfilePage
    {
        IWebDriver driver;
        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // click certificate tab
        IWebElement Certifications=> driver.FindElement(By.LinkText("Certifications"));
       
        // click on the add new button
        IWebElement AddCertificate=>driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div/div[2]/div/table/thead/tr/th[4]/div"));

        //insert certificate details
        IWebElement CertificateName=> driver.FindElement(By.Name("certificationName"));
        IWebElement CertificationIssuer=> driver.FindElement(By.Name("certificationFrom"));
        IWebElement CertificateYear=> driver.FindElement(By.Name("certificationYear"));
        SelectElement dropdown => new SelectElement(CertificateYear);
        IWebElement SubmitCertificate=> driver.FindElement(By.XPath("//input[@value='Add']"));
        //check if certificate is entered


        // go to the last row created
        IWebElement LastRow=>driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div/div[2]/div/table/tbody[last()]/tr"));
        //click edit button 
        IWebElement EditButtonCertificate => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div/div[2]/div/table/tbody[last()]/tr/td[4]/span/i"));
        //edit certificate
        IWebElement SubmitEditCertificate=> driver.FindElement(By.XPath("//input[@value='Update']"));

        // delete last record
        IWebElement DeleteButton => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]/i"));


        public void GotoCertificateTab()
        {
            TestContext.WriteLine("certification tab");
            Thread.Sleep(8000);
            Certifications.Click();
            TestContext.WriteLine("certification tab is clicked");
        }
        public void CreateCertificate()
        {
            TestContext.WriteLine("inside create certi function");

            AddCertificate.Click();
            CertificateName.SendKeys("ABCD");
            CertificationIssuer.SendKeys("EFGH");
            CertificateYear.Click();
            dropdown.SelectByValue("2020");
           

        }
        public void ClickCertificateSubmit()
        {
            TestContext.WriteLine("submit certi function");
            SubmitCertificate.Click();

        }

        public void ValidateSuccessCertificateCreation()
        {
            Thread.Sleep(8000);
            Assert.That(driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text, Is.EqualTo("ABCD"));

        }

        public void LastRowValue()
        {
            LastRow.Click();
        }

        public void EditCertificate()
        {
            EditButtonCertificate.Click();
            CertificateName.Clear();
            CertificateName.SendKeys("PQRS");
            CertificationIssuer.Clear();
            CertificationIssuer.SendKeys("UVWX");
            CertificateYear.Click();
            dropdown.SelectByValue("2016");
            
        }
        public void ClickEditSubmit()
        {
            SubmitEditCertificate.Click();
        }

        public void ValidateSuccessCertificateEdition()
        {
            Thread.Sleep(8000);
            Assert.That(driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text, Is.EqualTo("PQRS"));
        }
        public void DeleteCertificate()
        {
            DeleteButton.Click();
        }
    }
}
