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
      public void TestChangeLanguage()
        {
             IWebElement course = driver.FindElement(By.Id("Language"));
             var selectTest = new SelectElement(course);
            //Select a value from the dropdown				
             selectTest.SelectByValue("VbNet");
        }
      [Test]
      public void TestClear()
      {
          IWebElement course = driver.FindElement(By.Id("Console"));
         //Clear console			
          course.Clear();
      }
      
      [Test]
      public void TestClickNew()
      {
          IWebElement course = driver.FindElement(By.Id("new-button"));
          //Open new console			
          course.Click();
      }
    }
}