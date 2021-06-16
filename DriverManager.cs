using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestProjectMuramo
{
    [TestFixture]
    public static class DriverManager
    {
        public static IWebDriver driver;

        [SetUp]
        public static void startBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            options.AddArgument("--start-maximized");
          
            driver = new ChromeDriver("C:\\ChD", options, TimeSpan.FromMinutes(3));
            driver.Url = "https://dotnetfiddle.net";
            driver.Manage().Window.Maximize();
            
            IWebElement course = driver.FindElement(By.Id("Language")); 
            var selectTest = new SelectElement(course);
            // Select a value from the dropdown
            selectTest.SelectByValue("VbNet");
            
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));
        }
     
       [TearDown]
        public static void closeBrowser()
        {
            driver.Close();
        }
        
    }
}



//   driver.Navigate().GoToUrl("http://www.google.com/");
//   driver.FindElement(By.Name("q")).SendKeys("AutoQA.org");
//  driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);