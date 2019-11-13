using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace ApplitoolsHackathon.ApplitoolsTests
{
    //this will be run in Applitool because the browsertype = eyes, value that is taken from app.config <add key="BrowserType" value="eyes" />
    [TestFixture]
    public class ApplitoolsLoginTests_1 : Pages.Utils.Start
    {
        [Test(Description = "Go to Login Page and see if Login elements are present in the page")]
        [Category("Applitool")]
        public void ApplitoolOpenLoginPageTest()
        {
            Navigate(SiteV2);            
            MyEye.CheckWindow();
        }
    }
}
