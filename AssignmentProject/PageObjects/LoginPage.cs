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
    public class LoginPage
    {
        //driver.FindElement(By.LinkText("Login")
        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement login;

        public void ClickLogin()
        {
            login.Click();
        }

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement emailElement;

        public void TypeEmail()

        {
            emailElement.SendKeys("test@test.com);
        }

        [FindsBy(How = How.ClassName, Using = "le-input")]
        private IWebElement password;

        public void TypePassword()
        {
            passwordElement.Sendkeys("myPasswordisSecure");
        }

        [FindsBy(How = How.CssSelector, Using = "#login-form > div.buttons-holder.text-center > button")]
        private IWebElement signin;

        public void ClickSignin();
        {
            signin.Click();
        }



    
   
        
                        
        
    
}
