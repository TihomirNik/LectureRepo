using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TestWithLectors.AloneInClass.HomeWebElements;

namespace TestWithLectors
{
    [Binding]
    public class UsernameInAbvExistsSteps
    {

        ChromeDriver driver = new ChromeDriver();

        [Given(@"Navigate to ABV site")]
        public void GivenNavigateToABVSite()
        {
            HomeWebElements homeElements = new HomeWebElements(driver);
            driver.Navigate().GoToUrl(navigateToHomePage);
        }
        
        [When(@"I click to new register")]
        public void WhenIClickToNewRegister()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Enter ""(.*)""")]
        public void WhenEnter(string username)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Click on Check username")]
        public void WhenClickOnCheckUsername()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Message for validation")]
        public void ThenMessageForValidation()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
