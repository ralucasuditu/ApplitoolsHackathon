using NUnit.Framework;

namespace ApplitoolsHackathon.ApplitoolsTests
{
    //this will be run in Applitool because the browsertype = eyes, value that is taken from app.config <add key="BrowserType" value="eyes" />
    [TestFixture]
    public class ApplitoolsCanvas_4 : Pages.Utils.Start
    {
        [Test(Description = "Login, show canvas and check if canvas elements are displayed correctly")]
        [Category("Applitool")]
        public void ApplitoolCanvasTest()
        {
            
            Navigate(SiteV2);
            Login();
            MyEye.ForceFullPageScreenshot = true;

            Pages.Pages.MainPage.GetShowExpensesChart.Click();

            MyEye.CheckElement(OpenQA.Selenium.By.Id("canvas"));         

            Pages.Pages.MainPage.GetAddDataset.Click();

            MyEye.CheckElement(OpenQA.Selenium.By.Id("canvas"));
        }
    }
}