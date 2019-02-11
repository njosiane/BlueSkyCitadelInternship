using AssignmentProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentProject.PageObjects
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            OpenQA.Selenium.Chrome.ChromeDriver driver = Hooks.Driver;
            PageFactory.InitElements(driver : driver, page: this);
        }

        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement register { get; set; }

        public void ClickOnRegister()
        {
            register.Click();
        }


        [FindsBy(How = How.Id, Using = "first_name")]
        private IWebElement firstName { get; set; }

        public void EnterFirstName()
        {
            firstName.SendKeys("automation");
        }

        [FindsBy(How = How.Id, Using = "last_name")]
        private IWebElement lastName { get; set; }

        public void EnterLastName()
        {
            lastName.SendKeys("expert");
        }


        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailElement { get; set; }

        public void TypeEmail()
        {
            emailElement.SendKeys("automationexpert@mailinator.com");
        }

        internal void EnterEmailAddress(string v)
        {
            throw new NotImplementedException();
        }

        [FindsBy(How = How.Id, Using = "mobile")]
        private IWebElement mobileElement { get; set; }

        internal void EnterMobileNumber(string v)
        {
            throw new NotImplementedException();
        }

        public void TypeMobileNumber()
        {
            mobileElement.SendKeys("07111111111");
        }


        [FindsBy(How = How.ClassName, Using = "le-input")]
        private IWebElement passwordElement { get; set; }

        internal void EnterPassword(string v)
        {
            throw new NotImplementedException();
        }

        public void TypePassword()
        {
            passwordElement.SendKeys("automationexpert");
        }

        [FindsBy(How = How.Id, Using = "confirm_password")]
        private IWebElement confirmPasswordElement { get; set; }

        public void EnterConfirmPassword(string v)
        {
            confirmPasswordElement.SendKeys("automationexpert");
        }

        [FindsBy(How = How.CssSelector, Using = "#signup-form > div.buttons-holder.text-center > button")]
        private IWebElement signup { get; set; }

        public void ClickSignUp()
        {
            signup.Click();
        }

        [FindsBy(How = How.CssSelector, Using = "#login-form > div.alert.alert-success")]
        private IWebElement successMessage { get; set; }

        public bool successMessageIsDisplayed()
        {
            try
            {
                return successMessageIsDisplayed()
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
        


    }
}

    
    
