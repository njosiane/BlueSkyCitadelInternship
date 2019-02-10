using AssignmentProject.Utilities;
using System;
using TechTalk.SpecFlow;

namespace AssignmentProject.StepDefinitions
{
    [Binding]
    public class RegistrationSteps : Hooks
    {
        [Given(@"I click on the register link")]
        public void GivenIClickOnTheRegisterLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I am on the registration page")]
        public void GivenIAmOnTheRegistrationPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my first name")]
        public void WhenIEnterMyFirstName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my last name")]
        public void WhenIEnterMyLastName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my email ""(.*)""")]
        public void WhenIEnterMyEmail(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my mobile number")]
        public void WhenIEnterMyMobileNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I confirm my password")]
        public void WhenIConfirmMyPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the captcha box")]
        public void WhenIClickOnTheCaptchaBox()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am registered")]
        public void ThenIAmRegistered()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a thank you message is displayed")]
        public void ThenAThankYouMessageIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
