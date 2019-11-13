using NUnit.Framework;

namespace ApplitoolsHackathon.ApplitoolsTests
{
    //this will be run in Applitool because the browsertype = eyes, value that is taken from app.config <add key="BrowserType" value="eyes" />   
    [TestFixture]
    public class ApplitoolsDataDrivenTests_2 : Pages.Utils.Start
    {        
        [TestCase("", "", TestName = "LoginWithEmptyUsernameAndPassword")]
        [TestCase("", "Appl1t00ls2019", TestName = "LoginWithEmptyUsername")]
        [TestCase("raluca.suditu@gmail.com", "", TestName = "LoginWithEmptyPassword")]
        [Category("Applitool")]
        public void LoginInvalidCredendials(string username, string password)
        {                        
            Navigate(SiteV2);
            Pages.Pages.Login.GetUserName.SendKeys(username);            
            Pages.Pages.Login.GetUserPassword.SendKeys(password);
            Pages.Pages.Login.GetLogin.Click();

            /* There are several bugs here like:            
                - error message not displayed on a line for all cases
                - error message not displayed if only a correct username is entered and submit is performed */
            
            MyEye.CheckWindow();
        }

        [Test(Description = "Go to Login Page and test login with valid credentials")]
        [Category("Applitool")]
        public void LoginWithValidUsernamePassword()
        {
            Navigate(SiteV2);
            Login();            
            MyEye.CheckWindow();
        }
    }
}