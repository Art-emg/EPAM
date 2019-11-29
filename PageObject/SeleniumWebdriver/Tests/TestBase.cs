using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumWebdriver.Tests
{
    public class TestBase
    {
        protected IWebDriver _webDriver;

        [SetUp]
        public void StartBrowser()
        {
            _webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl("https://www.21vek.by/");
        }

        [TearDown]
        public void CloseBrowser()
        {
            _webDriver.Quit();
            _webDriver.Dispose();
        }

       
    }
}
