using NUnit.Framework;

namespace ApplitoolsHackathon.ClasicalTests
{
    //this uses the browsertype = chrome, value that is taken from app.config <add key="BrowserType" value="chrome" />    
    [TestFixture]
    public class DataDrivenTests_2 : Pages.Utils.Start
    {
        [TestCase("", "", "Please enter both username and password", TestName = "Check that validation is triggered when username/password are not entered")]
        [TestCase("rai@rms.ro", "", "Password must be present", TestName = "Check that validation is triggered password is not entered")]
        [TestCase("", "P1ncell0", "Username must be present", TestName = "Check that validation is triggered username is not entered")]
        [Category("Clasical")]
        public void LoginTestsValidations(string username, string password, string message)
        {
            Navigate(SiteV1);
            Pages.Pages.Login.GetUserName.SendKeys(username);            
            Pages.Pages.Login.GetUserPassword.SendKeys(password);
            Pages.Pages.Login.GetLogin.Click();
            
            //this will fail, since there are no validations on the V1 demo application
            Assert.AreEqual(message, Pages.Pages.Login.GetErrorMessage.Text);
        }

        [Test(Description = "Go to Login Page and test login with valid credentials")]
        [Category("Clasical")]
        public void LoginTestsValidCredentials()
        {
            Navigate(SiteV1);
            Login();
            Assert.AreEqual("Jack Gomez", Pages.Pages.MainPage.GetLoggedUsername.Text);            
        }
    }
}