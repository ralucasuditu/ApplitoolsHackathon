using System;
using System.Configuration;
using System.IO;
using Applitools.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using Applitools;

namespace ApplitoolsHackathon.Pages
{
    
    public class Driver
    {
        //--------------------------------------------------------------------------------------
        // Browser initilization
        //--------------------------------------------------------------------------------------
        
        public Eyes MyEye;

        public static IWebDriver Instance { get; set; }        

        public static string BrowserType
        {
            get { return GetConfigProperty("BrowserType"); }
        }

        public static string SiteV1
        {
            get { return GetConfigProperty("SiteV1"); }
        }

        public static string SiteDynamicV1
        {
            get { return GetConfigProperty("SiteDynamicV1"); }
        }

        public static string SiteV2
        {
            get { return GetConfigProperty("SiteV2"); }
        }

        public static string SiteDynamicV2
        {
            get { return GetConfigProperty("SiteDynamicV2"); }
        }

        public static string Username
        {
            get { return GetConfigProperty("Username"); }
        }

        public static string Password
        {
            get { return GetConfigProperty("Password"); }
        }

        public static string API_Key
        {
            get { return GetConfigProperty("API_Key"); }
        }

        public static string GetConfigProperty(string keyValue)
        {
            return ConfigurationManager.AppSettings[keyValue];
        }

        public static string GetClassName
        {            
            get { return NUnit.Framework.TestContext.CurrentContext.Test.ClassName; }
        }

        public static string GetTestName
        {
            get { return NUnit.Framework.TestContext.CurrentContext.Test.Name; }            
        }

        public void Intitialize(string testName)
        {           
            string chromeDriverPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ""));

            ChromeOptions chromeOptions = new ChromeOptions
            {
                Proxy = null
            };

            var browserType = BrowserType;

            switch (browserType)
            {
                case "chrome":
                    Instance = new ChromeDriver(chromeDriverPath, chromeOptions);
                    Instance.Manage().Window.Maximize();
                    break;

                case "eyes":
                    //we will batch tests by class name
                    BatchInfo batch = new BatchInfo(GetClassName);
                    ClassicRunner runner = new ClassicRunner();
                    MyEye = new Eyes(runner)
                    {
                        ApiKey = API_Key,
                        Batch = batch
                    };
                    Instance = new ChromeDriver();
                    Instance = MyEye.Open(Instance, "Applitools", testName, new Size(1366, 768));
                    break;                    
            }           
        }

        public void Close()
        {
            if (BrowserType == "chrome")
            {
                Instance.Close();
            }
            else
            {
                MyEye.Close();
                MyEye.AbortIfNotClosed();
                Instance.Close();
            }                           
        }
    }
}