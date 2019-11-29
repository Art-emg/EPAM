using System;
using System.Diagnostics;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using PageObject.PageObject;

namespace SeleniumWebdriver.Tests
{
    [TestFixture]
    public class SearchTest : TestBase
    {
       

        [Test]
        public void ErrorWhenRegistrationWithEmptyField()
        {
            string ErrorEmail = "Неправильный формат электронной почты.";
            MainPage mainPage = new MainPage(_webDriver);

            var registationForm = mainPage.ClickOnAccountField().ClickToRegistrationButton();
            registationForm.InputIncorrectEmail().ClickToRegistrationConfirmButton();
            Assert.AreEqual(ErrorEmail, registationForm.ErrorMessage.Text);
        }

        [Test]
        public void DiscountSubscriptionTest()
        {
            string ErrorEmail = "Спасибо за подписку!\r\n\r\nУдачных покупок в онлайн-гипермаркете 21vek.by!";
            MainPage mainPage = new MainPage(_webDriver);

            IJavaScriptExecutor js = (IJavaScriptExecutor)_webDriver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");

            var subscribeForm = mainPage.InputSubscribeName().InputSubscribeEmail();
            subscribeForm.ClickSubscribeButton();
            Assert.AreEqual(ErrorEmail, subscribeForm.SubscribeMessage.Text);
            Trace.WriteLine(subscribeForm.SubscribeMessage.Text);

        }

    }
}
