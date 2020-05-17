using Mars.Pages;
using NUnit.Framework;
using System;
using System.Runtime.ConstrainedExecution;
using TechTalk.SpecFlow;

namespace Mars.Steps
{
    [Binding]
    
    public class ProfileDetailsSteps :BaseHook
    {
        ProfilePage certiObj;
        LoginPage loginPage;
        [Given(@"user is logged in")]
        public void GivenUserIsLoggedIn()
        {
            loginPage = new LoginPage(driver);
            loginPage.LoginWithCredentials();


            certiObj = new ProfilePage(driver);
            TestContext.WriteLine("go to certi tab");
            certiObj.GotoCertificateTab();

        }
        
        [Given(@"entered certificate name, issuer, year")]
        public void GivenEnteredCertificateNameIssuerYear()
        {
            TestContext.WriteLine("go to create certi function");
            certiObj.CreateCertificate();
        }
        
        [Given(@"edited certificate name, issuer, year")]
        public void GivenEditedCertificateNameIssuerYear()
        {
            certiObj.LastRowValue();
            certiObj.EditCertificate();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            TestContext.WriteLine("go to click submit certi fn");
            certiObj.ClickCertificateSubmit();
        }
        
        [When(@"I press edit")]
        public void WhenIPressEdit()
        {
            certiObj.ClickEditSubmit();
        }
        
        [When(@"I press delete particular certificate")]
        public void WhenIPressDeleteParticularCertificate()
        {
            certiObj.LastRowValue();
            certiObj.DeleteCertificate();

        }
        
        [Then(@"the added certificate details should show")]
        public void ThenTheAddedCertificateDetailsShouldShow()
        {
            TestContext.WriteLine("go to validate create fn");
            certiObj.ValidateSuccessCertificateCreation();
        }
        
        [Then(@"the edited certificate details should show")]
        public void ThenTheEditedCertificateDetailsShouldShow()
        {
            certiObj.ValidateSuccessCertificateEdition();
        }
        
        [Then(@"the certificate should be deleted")]
        public void ThenTheCertificateShouldBeDeleted()
        {
            
        }
    }
}
