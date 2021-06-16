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
        [Test]
        public void Test1()
        {
            IWebElement course = driver.FindElement(By.Id("Language"));
            var selectTest = new SelectElement(course);
            // Select a value from the dropdown				
            selectTest.SelectByValue("VbNet");
        }

        [TearDown]
        public void TearDownBrowser()
        {
            DriverManager.CloseBrowser();
        }
    }
}