using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace ApplitoolsHackathon.ApplitoolsTests
{
    //You can set whatever batch name here; by default it is set to take the testname
    [TestFixture]
    public class ApplitoolsTableSortTests_3 : Pages.Utils.Start
    {
        [Test(Description = "Login, sort amount and check if sorting is applied")]
        [Category("Applitool")]
        public void ApplitoolTableSortTest()
        {
            Navigate(SiteV2);
            Login();
            MyEye.ForceFullPageScreenshot = true;
            Pages.Pages.MainPage.GetAmountHeaderCell.Click();
            
            MyEye.CheckWindow();
        }
    }
}
