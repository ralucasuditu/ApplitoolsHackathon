using NUnit.Framework;

namespace ApplitoolsHackathon.ClasicalTests
{
    //this uses the browsertype = chrome, value that is taken from app.config <add key="BrowserType" value="chrome" />    
    [TestFixture]
    public class ClasicalDynamicTests_5 : Pages.Utils.Start
    {                
        [Test(Description = "Login in the dynamic page and check if the 2 gifs are on the page")]
        [Category("Clasical")]
        public void DynamicContentTests()
        {            
            Navigate(SiteDynamicV1);

            Login();

            Assert.AreEqual(true, Pages.Pages.MainPage.GetFlashSale1.Displayed);
            Assert.AreEqual(true, Pages.Pages.MainPage.GetFlashSale2.Displayed);
        }        
    }
}