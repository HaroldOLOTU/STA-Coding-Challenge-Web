using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TflJourneyPlanner.Hook;
using SeleniumExtras.WaitHelpers;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using OpenQA.Selenium.Interactions;

namespace TflJourneyPlanner.PageObjects
{
    public class JourneyPlannerWidgetPage
    {
        public IWebDriver driver;

        public JourneyPlannerWidgetPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        private By planMyJourneyButton = By.Id("plan-journey-button");
        private By journeyResults = By.XPath("//*[@id=\"jp-new-content-home-\"]");
        private By cyclingTime = By.XPath("//*[@id=\"full-width-content\"]/div/div[7]/div/div[1]/a[1]");
        private By walkingTime = By.XPath("//*[@id=\"full-width-content\"]/div/div[7]/div/div[1]/a[2]");
        private By editPreferencesLink = By.XPath("//*[@id=\"plan-a-journey\"]/div[3]/div[4]/button");
        private By leastWalkingOption = By.XPath("//*[@id=\"more-journey-options\"]/div/fieldset/ul[2]/li[1]/fieldset/div/div/div[1]/label[3]");
        private By updateJourneyButton = By.XPath("//*[@id=\"more-journey-options\"]/div/fieldset/div[2]/div/input[2]");
        private By journeyTime = By.XPath("//*[@id=\"option-1-heading\"]/div[1]");
        private By viewDetailsButton = By.XPath("(//button[@class='secondary-button show-detailed-results view-hide-details'])[1]");
        private By accessibilityDetailsLink = By.XPath("(//summary[@class='accordion-heading'])[1]");
        private By completeAccessInformation = By.XPath("//*[@id=\"option-1-accessibility-content\"]");
        private By invalidJourneyErrorMessage = By.XPath("//li[@class='field-validation-error']");
        private By blankStartLocationTxtBox = By.Id("InputFrom");
        private By blankEndLocationTxtBox = By.Id("InputTo");
        private By fromFieldIsRequiredErrMsg = By.XPath("//*[@id=\"search-filter-form-0\"]/div/span");
        private By toFieldIsRequiredErrMsg = By.XPath("//*[@id=\"search-filter-form-1\"]/span[1]");
     
        public void SelectFromAutoSuggestion(string startStaion)

        {
            var fromField = driver.FindElement(By.Id("InputFrom"));
            fromField.Clear();
            fromField.SendKeys(startStaion);
            Actions actions = new Actions(driver);
            IWebElement startJourney = driver.FindElement(By.XPath("(//span[@class='stop-name'])[1]"));
             actions.Click(startJourney).Perform();    
        }
     
        public void SelectToAutoSuggestion(string endStation)
        {

            var toField = driver.FindElement(By.Id("InputTo"));
            toField.Clear();
            toField.SendKeys(endStation);
            Actions actions = new Actions(driver);
            IWebElement endJourney = driver.FindElement(By.XPath("(//span[@class='stop-name'])[1]"));
            actions.Click(endJourney).Perform();
        }
        public void EnterInvalidStartStation(string startStation)
        {
            var fromField = driver.FindElement(By.Id("InputFrom"));
            fromField.Clear();
            fromField.SendKeys(startStation);
        }

        public void EnterInvalidEndStation(string endStation)
        {

            var toField = driver.FindElement(By.Id("InputTo"));
            toField.Clear();
            toField.SendKeys(endStation);
        }
        public void ClickPlanMyJourneyButton()
        {
            driver.FindElement(planMyJourneyButton).Click();
        }
        public bool AreJourneyResultsDidplayed()
        {
            return driver.FindElement(journeyResults).Displayed;
        }
        public bool IsWalkingTimeDisplayed()
        {
            return driver.FindElement(walkingTime).Displayed;   
        }
        public bool IsCyclingTimeDisplayed()
        {
            return driver.FindElement(cyclingTime).Displayed;
        }
        public void ClickEditPreferences()
        {
            driver.FindElement(editPreferencesLink).Click();
        }
        public void SelectLeastWalkingOption()
        {
            driver.FindElement(leastWalkingOption).Click();
        }
        public void ClickUpdateJourneyButton()
        {
            driver.FindElement(updateJourneyButton).Click();
        }
        public bool IsUpdatedJourneyTimeDisplayed()
        {
            return driver.FindElement(journeyTime).Displayed;
        }
        public void ClickViewDetailsButton()
        {
            driver.FindElement(viewDetailsButton).Click();
        }
        public void ClickAccessibilityDetailsLink()
        {
            driver.FindElement(accessibilityDetailsLink).Click();
        }
        public bool IscompleteAccessInformationDisplayed()
        {
            return driver.FindElement(completeAccessInformation).Displayed;
        }
        public bool IsInvalidJourneyErrorMessageDisplayed()
        {
            return driver.FindElement(invalidJourneyErrorMessage).Displayed;
        }
        public void ClearBlankStartLocationTxtBox()
        {
            driver.FindElement(blankStartLocationTxtBox).Clear();
        }
        public void ClearEndStartLocationTxtBox()
        {
            driver.FindElement(blankEndLocationTxtBox).Clear();
        }
        public bool IsFromFieldIsRequiredErrMsgDisplayed()
        {
            return driver.FindElement(fromFieldIsRequiredErrMsg).Displayed;
        }
        public bool IsToFieldIsRequiredErrMsgDisplayed()
        {
            return driver.FindElement(toFieldIsRequiredErrMsg).Displayed;
        }


    }
}
