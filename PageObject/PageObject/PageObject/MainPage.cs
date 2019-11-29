using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace PageObject.PageObject
{
    public class MainPage : BasePage
    {
        private const string accountButtonField = "/html/body/div[3]/div[2]/div/ul[2]/li[1]/a";
        private const string registrationButtonOnForm = "//*[@id=\"react-popup\"]/div/div[2]/div[5]/div[2]/a";
        private const string registrationEmailInput = "//*[@id=\"react-popup\"]/div/div[2]/div[2]/div[2]/input";
        private const string confirmRegistrationButton = "//*[@id=\"react-popup\"]/div/div[2]/div[3]";
        private const string outputErrorMessage = "//*[@id=\"react-popup\"]/div/div[2]/div[2]/div[3]/div[2]";

        private const string inputSubscribeName = "//*[@id=\"subscription-form\"]/span[1]/input";
        private const string inputSubscribeEmail = "//*[@id=\"subscription-form\"]/span[2]/input";
        private const string subscribeButton = "//*[@id=\"subscription-form\"]/button";
        private const string outputSubscribeMessage = "//div[@class=\"text\"]";


        [FindsBy(How = How.XPath, Using = accountButtonField)]
        public IWebElement AccountButton { get; set; }

        [FindsBy(How = How.XPath, Using = registrationButtonOnForm)]
        public IWebElement RegistrationButton { get; set; }

        [FindsBy(How = How.XPath, Using = registrationEmailInput)]
        public IWebElement RegistrationEmailInput { get; set; }

        [FindsBy(How = How.XPath, Using = confirmRegistrationButton)]
        public IWebElement RegistrationConfirmButton { get; set; }

        [FindsBy(How = How.XPath, Using = outputErrorMessage)]
        public IWebElement ErrorMessage { get; set; }


        [FindsBy(How = How.XPath, Using = inputSubscribeName)]
        public IWebElement SubscribeName { get; set; }

        [FindsBy(How = How.XPath, Using = inputSubscribeEmail)]
        public IWebElement SubscribeEmail { get; set; }

        [FindsBy(How = How.XPath, Using = subscribeButton)]
        public IWebElement SubscribeButton { get; set; }

        [FindsBy(How = How.XPath, Using = outputSubscribeMessage)]
        public IWebElement SubscribeMessage { get; set; }


        private MainPage()
        {
        }

        public MainPage(IWebDriver driver)
        {
            Driver = driver;
            InitPage(driver, this);
        }

        public MainPage ClickOnAccountField()
        {
            AccountButton.Click();
            return new MainPage(Driver);
        }

        public MainPage ClickToRegistrationButton()
        {
            RegistrationButton.Click();
            return new MainPage(Driver);
        }
        public MainPage InputIncorrectEmail()
        {
            RegistrationEmailInput.SendKeys("qwerty");
            return new MainPage(Driver);
        }

        public MainPage ClickToRegistrationConfirmButton()
        {
            RegistrationConfirmButton.Click();
            return new MainPage(Driver);
        }
        

        public MainPage InputSubscribeName()
        {
            SubscribeName.SendKeys("TestName");
            return new MainPage(Driver);
        }
        public MainPage InputSubscribeEmail()
        {
            SubscribeEmail.SendKeys("test@test.com");
            return new MainPage(Driver);
        }
        public MainPage ClickSubscribeButton()
        {
            SubscribeButton.Click();
            return new MainPage(Driver);
        }


    }
}
