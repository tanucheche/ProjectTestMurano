using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProjectMuramo
{
    public class LogInPage : BaseTests
    {
        //здесь будут тесты на логин
        [Test]
                public void Test1()
                {
                    IWebElement course = driver.FindElement(By.Id("Language"));
                    var selectTest = new SelectElement(course);
                    // Select a value from the dropdown				
                    selectTest.("VbNet");
                }
    }
}