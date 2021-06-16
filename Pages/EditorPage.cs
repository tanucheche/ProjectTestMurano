using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace TestProjectMuramo
{
    public class EditorPage : BaseTests
    {
        //здесь будут тесты на редактирование страницы
       [Test]
      public void Test1()
        {
             IWebElement course = driver.FindElement(By.Id("Language"));
             var selectTest = new SelectElement(course);
            //Select a value from the dropdown				
             selectTest.SelectByValue("VbNet");
            
        }
    }
}