using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWithLectors.AloneInClass.RegisterWebElements
{
    class RegisterWebElements
    {
        IWebDriver driver;


        readonly By usernameInputField = By.CssSelector("#regformUsername");
        readonly By buttonToCheck = By.CssSelector(".abv-button");
        readonly By errorMessage = By.CssSelector(".abv-error");

        public RegisterWebElements(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void enterUsername(string username)
        {
            driver.FindElement(usernameInputField).SendKeys(username);
        }

        public void clickButton()
        {
            driver.FindElement(buttonToCheck).Click();
        }

        public bool isCreated()
        {
            return driver.FindElement(errorMessage).Text.Equals("Потребителското име е заето");
        }
    }
}
