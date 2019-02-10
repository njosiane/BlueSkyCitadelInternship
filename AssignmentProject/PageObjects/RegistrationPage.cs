using AssignmentProject.Utilities;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentProject.PageObjects
{
    class RegistrationPage()
    {
    
        public RegistrationPage()
    {
        PageFactory.InitElements(Hooks.Driver, this);
    }

    [FindsBy(How = How.LinkText, Using = "Register")]
    private IWebElement register { get; set; }
    public void ClickLogin()
    {
        register.Click();
    }

    [FindsBy(How = How.Id, Using = "first_name")]
    private IWebElement firstName { get; set; }

    public void EnterFirstName()
    {
        firstname.SendKeys(myfirstname);
    }

    [FindsBy(How = How.CssSelector, Using = "#last_name")]
    private IWebElement lastName { get; set; }

    public void EnterLastName()
    {
        lastname.SendKeys(mylastname);
    }

    [FindsBy(How = How.XPath, Using = "//*[@id='mobile']")]
    private IWebElement mobile; { get; set; }

    public void EnterMobile()
    {
        mobile.SendKeys(07111711111);
    }

    [FindsBy(How = How.Id, Using = "password")]
    private IWebElement password; { get; set; }

    public void Enterpassword()
    {
      password.SendKeys(mypasswordissecure);
    }

    [FindsBy(How = How.Id, Using = "confirm_password")]
    private IWebElement confirmPassword; { get; set; }

    public void TypePassword()
    {
        Confirmpassword.SendKeys("mypasswordissecure");
    }

    [FindsBy(How = How.id, Using = "email")]
    private IWebElement emailaddress { get; set; }

    public void EnterEmailAddress()
    {
        emailaddress.SendKeys("test@test.com");
    }

    [FindsBy(How = How.CssSelector, Using = "#signup-form > div.buttons-holder.text.center > button")]
    private IWebElement signup { get; set; }

    public void ClickSignUp();
    {
    lastname.SendKeys(lastnameText);
    }

}
}
