using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace ApplitoolsHackathon.Pages.Utils
{
    [TestClass]
    public class Start : Driver
    {
        [SetUp()]
        public void SetUp()
        {
            // Applitool test name will be represented by the Test name
            Intitialize(GetTestName);
        }

        [TearDown()]
        public void TearDown()
        {            
            Close();
        }

        public void Navigate(string url)
        {
            Instance.Navigate().GoToUrl(url);
        }        

        public void Login()
        {            
            Pages.Login.GetUserName.SendKeys(Username);         
            Pages.Login.GetUserPassword.SendKeys(Password);
            Pages.Login.GetLogin.Click();
        }
    }
}