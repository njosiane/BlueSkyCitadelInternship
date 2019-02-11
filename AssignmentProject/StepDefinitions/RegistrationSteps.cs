using AssignmentProject.Utilities;
using System;
using TechTalk.SpecFlow;
using AssignmentProject.PageObjects;
using NUnit.Framework;
using System.Threading;

namespace AssignmentProject.StepDefinitions
{
    [Binding]
    public class RegistrationSteps

    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }
        
        [Given(@"I navigate to homepage")]
        public void GivenINavigateToHomepage()
        {
            Hooks.Driver.Navigate().GoToUrl("http://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximise();
        }

        [When(@"I click on register link")]
        public void WhenIClickOnRegisterLink()
        {
            registrationPage.ClickOnRegister();
        }
        
        
        [When(@"I enter my first name")]
        public void WhenIEnterMyFirstName()
        {
            registrationPage.EnterFirstName();
        }
        
        [When(@"I enter my last name")]
        public void WhenIEnterMyLastName()
        {
            registrationPage.EnterFirstName();
        }
        
        [When(@"I enter my email")]
        public void WhenIEnterMyEmail()
        {
            registrationPage.EnterEmailAddress("automationexpert@mailinator.com");
        }
        
        [When(@"I enter my mobile number")]
        public void WhenIEnterMyMobileNumber()
        {
            registrationPage.EnterMobileNumber("07111111111");
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            registrationPage.EnterPassword("automationexpert");
        }
        
        [When(@"I confirm my password")]
        public void WhenIConfirmMyPassword()
        {
            registrationPage.EnterConfirmPassword("automationexpert");
        }
        
        
        [When(@"I click on sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            signup.Click();
        }
        
        [Then(@"I am registered")]
        public void ThenIAmRegistered()
        {
            Thread.Sleep(30000);
            
            //Assert.Equals(registrationPage.successMessageIsDisplayed(), true);
            //Assert.IsTrue(registrationPage.successMessageIsDisplayed(), "Error Message: Registration failed");

            registrationPage.successMessageIsDisplayed().Should().BeTrue("Error Message: Registration failed");
            //registrationPage.successMessageIsDisplayed().Should().Be(true)("Error Message: Registration failed")
        }
        
    }
}
