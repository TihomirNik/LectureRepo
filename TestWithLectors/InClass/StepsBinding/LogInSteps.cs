using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TestWithLectors.WebElements;

namespace TestWithLectors
{
    [Binding]
    public class LogInSteps : IDisposable
    {
        private ChromeDriver driver = new ChromeDriver();

        [Given(@"I navigate to web Scraper homepage")]
        public void GivenINavigateToWebScraperHomepage()
        {
            LogInPage logInPage = new LogInPage(driver);
            driver.Navigate().GoToUrl(logInPage.homePage);
        }

        [When(@"I enter my ""(.*)"" in username field")]
        public void WhenIEnterMyInUsernameField(string username)
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.enterUsername(username);
        }

        [When(@"I enter my ""(.*)"" in password field")]
        public void WhenIEnterMyInPasswordField(string password)
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.enterPassword(password);
        }

        [When(@"I Click on login button")]
        public void WhenIClickOnLoginButton()
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.clickLoginButton();
        }
        
        [Then(@"I should see Welcome message")]
        public void ThenIShouldSeeWelcomeMessage()
        {
            LogInPage logInPage = new LogInPage(driver);
            Assert.IsTrue(logInPage.isWelcomeMessageDisplayed());
        }

        public void Dispose()
        {
            if (driver != null )
            {
                driver.Dispose();
                driver = null;
            }
        }
    }
}
