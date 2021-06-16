using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestProjectMuramo
{
    [TestFixture]
    public class BaseTests
    {
        protected static IWebDriver driver => DriverManager.driver;
        
        [SetUp]
        public void SetUpBrowser()
        {
            DriverManager.StartBrowser(); 
        }
        
        [TearDown]
        public void TearDownBrowser()
        {
            DriverManager.CloseBrowser();
        }
    }
}