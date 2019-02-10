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
            driver.Navigate().GoToUrl("http://www.giftrete.com")      
         }
            

        [Given(@"I click on the login link")]
        public void GivenIClickOnTheLoginLink()
        {
            loginPage.ClickLogin();
        }
        
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my valid email address")]
        public void WhenIEnterMyValidEmailAddress()
        {
            loginPage.TypeEmail();
        }
        
        [When(@"I enter my corresponding valid password")]
        public void WhenIEnterMyCorrespondingValidPassword()
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
