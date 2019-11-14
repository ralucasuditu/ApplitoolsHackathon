using NUnit.Framework;

namespace ApplitoolsHackathon.ClasicalTests
{
    //this uses the browsertype = chrome, value that is taken from app.config <add key="BrowserType" value="chrome" />    
    [TestFixture]
    public class ClasicalTableSortTests_3 : Pages.Utils.Start
    {                
        [Test(Description = "Login, sort amount and check if sorting is applied")]
        [Category("Clasical")]
        public void TableSortTest()
        {
            //this is much easier to be tested with Applitools          
        }        
    }
}