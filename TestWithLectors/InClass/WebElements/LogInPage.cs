using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWithLectors.WebElements
{
    class LogInPage
    {
        public string homePage = "http://testing-ground.scraping.pro/login";

        private IWebDriver driver;

        public LogInPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        readonly By usernameField = By.CssSelector("#usr");
        readonly By passwordField = By.CssSelector("#pwd");
        readonly By loginButton = By.CssSelector("[type='submit']");
        readonly By wellcomeMessage = By.CssSelector("#case_login .success");


        public void enterUsername(string username)
        {
            driver.FindElement(usernameField).Clear();
            driver.FindElement(usernameField).SendKeys(username);
         }

        public void enterPassword(string password)
        {
            driver.FindElement(passwordField).Clear();
            driver.FindElement(passwordField).SendKeys(password);
         }

        public void clickLoginButton()
        {
            driver.FindElement(loginButton).Click();
        }

        public bool isWelcomeMessageDisplayed()
        {
            return driver.FindElement(wellcomeMessage).Displayed;
        }
    }
}
