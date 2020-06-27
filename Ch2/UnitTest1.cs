using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Ch2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string mytext;
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://testing.todvachev.com/");

            mytext = driver.FindElement(By.XPath("//*[@id='menu-item-35']/a")).Text;

            driver.FindElement(By.XPath($"//*[@id='search-2']/form/label/input")).SendKeys(mytext);

            Thread.Sleep(2000);

            driver.FindElement(By.Id("menu-item-106")).Click();

            Thread.Sleep(2000);

            driver.Quit();
        }
    }
}
