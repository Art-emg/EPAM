using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace Tests
{
    public class Tests
    {
        private IWebDriver _webDriver;

        [SetUp]
        public void Setup()
        {
            _webDriver = new OpenQA.Selenium.Chrome.ChromeDriver(@"C:\Users\User\source\repos\SeleniumWebDriver\SeleniumWebDriver\bin\Debug\netcoreapp2.2");
            _webDriver.Navigate().GoToUrl("https://www.21vek.by/");
        }

        [Test]
        public void AuthorizationTest()
        {
            IWebElement enterFormButton = GetWebElement("/html/body/div[3]/div[2]/div/ul[2]/li[1]/a");
            enterFormButton.Click();
            Thread.Sleep(1000);

            IWebElement inputLogin = GetWebElement("/html/body/div[1]/div/div[2]/div[2]/div[2]/input");
            inputLogin.SendKeys("xaejjqrofyuh@dropmail.me");

            IWebElement inputPass = GetWebElement("/html/body/div[1]/div/div[2]/div[3]/div[2]/input");
            inputPass.SendKeys("FGx8QrU6");

            IWebElement enterButton = GetWebElement("/html/body/div[1]/div/div[2]/div[4]");
            enterButton.Click();

            IWebElement authText = GetWebElement(
                "/html/body/div[3]/div[2]/div/ul[2]/li/span/span/span");
            

            Assert.IsTrue(authText.Text.Equals("Моё"));
        }



        [Test]
        public void AddToCartTest()
        {
            IWebElement firstPopularProduct = GetWebElement("/html/body/div[3]/div[6]/div[1]/div[1]/div/div/div/ul/li[1]/div/span[1]/a");
            firstPopularProduct.Click();

            IWebElement addButton = GetWebElement("/html/body/div[3]/div[5]/div[1]/div/div[3]/div[1]/div[2]/div[1]/div[1]/form/button");
            addButton.Click();

            IWebElement checkInCart = GetWebElement("/html/body/div[3]/div[5]/div[1]/div/div[3]/div[1]/div[2]/div[1]/div[1]/a");
            Assert.IsTrue(checkInCart.Text.Equals("В корзине"));
        }

        private IWebElement GetWebElement(string xPath)
        {
            return _webDriver.FindElement(By.XPath(xPath));
        }
    }
}