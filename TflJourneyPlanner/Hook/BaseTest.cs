using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;

namespace TflJourneyPlanner.Hook
{
    [Binding]
    public class BaseTest
    {
        public static IWebDriver? driver;

        [BeforeScenario()]
        public static void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://tfl.gov.uk/plan-a-journey");
            // Accept All Cookies
            driver.FindElement(By.XPath("//button[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }



        [AfterScenario]
        public void Teardown()
        {
            driver.Close();
            driver.Quit();
        }

    }

    }