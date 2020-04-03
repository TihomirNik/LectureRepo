using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWithLectors.AloneInClass.HomeWebElements
{
    class HomeWebElements
    {
        private string homePage = "https://www.abv.bg/";

        IWebDriver driver;
        readonly By regButton = By.CssSelector("div#leftSide > a:nth-of-type(2)");
        public HomeWebElements (IWebDriver driver)
        {
            this.driver = driver;
        }

        public void navigateToHomePage()
        {
            driver.Navigate().GoToUrl(homePage);
        }

        public void openRegisterForm()
        {
            driver.FindElement(regButton).Click();
        }
    }
}