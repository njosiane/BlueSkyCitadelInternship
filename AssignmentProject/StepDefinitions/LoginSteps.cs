using AssignmentProject.PageObjects;
using AssignmentProject.Utilities;
using System;
using TechTalk.SpecFlow;

namespace AssignmentProject.StepDefinitions
{
    [Binding]
    public class LoginSteps : Hooks
    {
        LoginPage loginPage;


        public LoginSteps()
        {
            loginPage = new LoginPage();
        }


        [Given(@"I navigate to the homepage")]
        public void GivenINavigateToTheHomepage()
        {
            driver.Navigate().GoToUrl("http://giftrete.com");
        }
        
        [When(@"I click on the login link")]
        public void WhenIClickOnTheLoginLink()
        {
            loginPage.ClickLogin();
        }
        
        [When(@"I enter my registered email address")]
        public void WhenIEnterMyRegisteredEmailAddress()
        {
            loginPage.TypeEmail();
        }
        
        [When(@"I enter my registered password")]
        public void WhenIEnterMyRegisteredPassword()
        {
            loginPage.TypePassword();
        }
        
        [When(@"I click on the secure sign in button")]
        public void WhenIClickOnTheSecureSignInButton()
        {
            loginPage.ClickSignin();
        }
        
        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"my account page is displayed")]
        public void ThenMyAccountPageIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
