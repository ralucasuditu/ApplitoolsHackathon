using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace ApplitoolsHackathon.Pages.Pages
{
    [TestClass]
    public class MainPage : Driver
    {        
        public static IWebElement GetLoggedUsername
        {
            get { return Instance.FindElement(By.XPath("/html/body/div/div[3]/div[1]/div/div/div[2]/div[1]")); }
        }

        public static IWebElement GetAmountHeaderCell
        {
            get { return Instance.FindElement(By.Id("amount")); }
        }

        public static IWebElement GetShowExpensesChart
        {
            get { return Instance.FindElement(By.Id("showExpensesChart")); }
        }

        public static IWebElement GetAddDataset
        {
            get { return Instance.FindElement(By.Id("addDataset")); }
        }

        public static IWebElement GetFlashSale1
        {
            get { return Instance.FindElement(By.XPath("//*[@id='flashSale']/img")); }
        }

        public static IWebElement GetFlashSale2
        {
            get { return Instance.FindElement(By.XPath("//*[@id='flashSale2']/img")); }
        }

        //Here, we can identify more page elements       
    }
}
