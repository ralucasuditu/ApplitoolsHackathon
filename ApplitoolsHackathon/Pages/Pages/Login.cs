using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace ApplitoolsHackathon.Pages.Pages
{
    [TestClass]
    public class Login : Driver
    {        
        public static IWebElement GetUserName
        {
            get { return Instance.FindElement(By.Id("username")); }
        }

        public static IWebElement GetUserPassword
        {
            get { return Instance.FindElement(By.Id("password")); }
        }

        public static IWebElement GetLogin
        {
            get { return Instance.FindElement(By.Id("log-in")); }
        }

        public static IWebElement GetLoginForm
        {
            get { return Instance.FindElement(By.CssSelector("body > div > div > h4")); }
        }

        public static IWebElement GetUserNameLabel
        {
            get { return Instance.FindElement(By.CssSelector("body > div > div > form > div:nth-child(1) > label")); }
        }

        public static IWebElement GetUserPasswordLabel
        {
            get { return Instance.FindElement(By.CssSelector("body > div > div > form > div:nth-child(2) > label")); }
        }

        public static IWebElement GetRememberMeLable
        {
            get { return Instance.FindElement(By.CssSelector("body > div > div > form > div.buttons-w > div.form-check-inline > label")); }
        }

        public static IWebElement GetErrorMessage
        {
            get { return Instance.FindElement(By.Id("random_id_1")); }
        }

        //Here, we can identify more page elements, like user/pass icon, twitter, facebook, linkedin icons and to check if these elements exist on the page        
    }
}
