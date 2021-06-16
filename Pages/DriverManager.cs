using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProjectMuramo
{
   public class DriverManager
    {
       public static IWebDriver driver { get; private set; };

       public void StartBrowser()
        {
            //Add options for opening browser with more timespan
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            options.AddArgument("--start-maximized");
          
            driver = new ChromeDriver("C:\\ChD", options, TimeSpan.FromMinutes(3)); 
            
            driver.Url = "https://dotnetfiddle.net";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));
        }
     
        public void CloseBrowser()
        {
            driver.Close();
        }
        
    }
}

