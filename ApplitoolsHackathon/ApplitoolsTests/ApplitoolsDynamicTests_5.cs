using NUnit.Framework;

namespace ApplitoolsHackathon.ApplitoolsTests
{
    //this will be run in Applitool because the browsertype = eyes, value that is taken from app.config <add key="BrowserType" value="eyes" />
    [TestFixture]
    public class ApplitoolsDynamicTests_5 : Pages.Utils.Start
    {
        [Test(Description = "Login in the dynamic page and check if the 2 gifs are on the page")]
        [Category("Applitool")]
        public void DynamicContentTest()
        {
            //the matchlevel was set to Layout2 considering that the images are dynamic
            //to capture the missing gif, the test was run first with the V1 url, in order to set the correct baseline and the to V2 url, in order to catch the bug
            Navigate(SiteDynamicV2);
            Login();
            MyEye.ForceFullPageScreenshot = true;            
            MyEye.MatchLevel = Applitools.MatchLevel.Layout2;
            
            MyEye.CheckWindow();
        }
    }
}