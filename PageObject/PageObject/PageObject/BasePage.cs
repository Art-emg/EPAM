using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObject.PageObject
{
    public abstract class BasePage
    {
        protected IWebDriver Driver;

        protected void InitPage<T>(IWebDriver driver, T page) where T : BasePage
        {
            PageFactory.InitElements(driver, page);
        }
    }

}
