using NUnit.Framework;

namespace ApplitoolsHackathon.ClasicalTests
{
    //this uses the browsertype = chrome, value that is taken from app.config <add key="BrowserType" value="chrome" />    
    [TestFixture]
    public class ClasicalLoginTests_1 : Pages.Utils.Start
    {                
        [Test(Description = "Go to Login Page and see if Login elements are present in the page")]
        [Category("Clasical")]
        public void LoginTests()
        {
            Navigate(SiteV1);
            Assert.AreEqual("Username", Pages.Pages.Login.GetUserNameLabel.Text);
            Assert.AreEqual("Password", Pages.Pages.Login.GetUserPasswordLabel.Text);
            Assert.AreEqual("Login Form", Pages.Pages.Login.GetLoginForm.Text);
            Assert.AreEqual("Remember Me", Pages.Pages.Login.GetRememberMeLable.Text);                     
        }        
    }
}