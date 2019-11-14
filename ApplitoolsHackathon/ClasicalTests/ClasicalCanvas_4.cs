using NUnit.Framework;

namespace ApplitoolsHackathon.ClasicalTests
{
    //this uses the browsertype = chrome, value that is taken from app.config <add key="BrowserType" value="chrome" />    
    [TestFixture]
    public class ClasicalCanvas_4 : Pages.Utils.Start
    {                
        [Test(Description = "Login, show canvas and check if canvas elements are displayed correctly")]
        [Category("Clasical")]
        public void CanvasTest()
        {
            //this is much easier to be tested with Applitools          
        }        
    }
}