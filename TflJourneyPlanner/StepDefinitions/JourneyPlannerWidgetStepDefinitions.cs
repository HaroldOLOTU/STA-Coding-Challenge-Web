using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using System;
using System.Numerics;
using TechTalk.SpecFlow;
using TflJourneyPlanner.Hook;
using TflJourneyPlanner.PageObjects;

namespace TflJourneyPlanner.StepDefinitions
{
    [Binding]
    public class JourneyPlannerWidgetStepDefinitions
    {
        JourneyPlannerWidgetPage journeyPlannerWidgetPage = new JourneyPlannerWidgetPage(BaseTest.driver); 

        [Given(@"I am on the Journey Planner page")]
        public void GivenIAmOnTheJourneyPlannerPage()
        {
            journeyPlannerWidgetPage = new JourneyPlannerWidgetPage(BaseTest.driver);  
        }

       

        [When(@"User selects Leicester Square Underground Station from the autocomplete suggestions\.")]
        public void WhenUserSelectsLeicesterSquareUndergroundStationFromTheAutocompleteSuggestions_()
        {

            //journeyPlannerWidgetPage.SelectFromAutoSuggestion();
        }

      
        [When(@"User selects Covent Garden Underground Station from the autocomplete suggestions\.")]
        public void WhenUserSelectsCoventGardenUndergroundStationFromTheAutocompleteSuggestions_()
        {
           // journeyPlannerWidgetPage.SelectToAutoSuggestion();  
        }
        [When(@"User Enters ""([^""]*)"" to select station for start Journey")]
        public void WhenUserEntersToSelectStationForStartJourney(string startStaion)
        {
            journeyPlannerWidgetPage.SelectFromAutoSuggestion(startStaion);
        }

        [When(@"User enters ""([^""]*)"" to select station for end Journey")]
        public void WhenUserEntersToSelectStationForEndJourney(string endStation)
        {
            journeyPlannerWidgetPage.SelectToAutoSuggestion(endStation);
        }
        [When(@"User Enters invalid ""([^""]*)"" to select station for start Journey")]
        public void WhenUserEntersInvalidToSelectStationForStartJourney(string startStation)
        {
            journeyPlannerWidgetPage.EnterInvalidStartStation(startStation);  
        }

        [When(@"User enters invalid ""([^""]*)"" to select station for end Journey")]
        public void WhenUserEntersInvalidToSelectStationForEndJourney(string endstation)
        {
            journeyPlannerWidgetPage.EnterInvalidEndStation(endstation);
        }



        [When(@"User clicks the Plan my journey button\.")]
        public void WhenUserClicksThePlanMyJourneyButton_()
        {
            journeyPlannerWidgetPage.ClickPlanMyJourneyButton();    
        }

        [Then(@"the journey results should be displayed\.")]
        public void ThenTheJourneyResultsShouldBeDisplayed_()
        {
            Assert.That(journeyPlannerWidgetPage.AreJourneyResultsDidplayed(), Is.True);             
                
        }

        [Then(@"the walking and cycling journey times should be displayed\.")]
        public void ThenTheWalkingAndCyclingJourneyTimesShouldBeDisplayed_()
        {
            Assert.That(journeyPlannerWidgetPage.IsWalkingTimeDisplayed(), Is.True);
            Assert.That(journeyPlannerWidgetPage.IsCyclingTimeDisplayed(), Is.True);

        }

        [Then(@"User clicks Edit preferences link")]
        public void ThenUserClicksEditPreferencesLink()
        {
            journeyPlannerWidgetPage.ClickEditPreferences();
        }

        [Then(@"User selects Routes with least walking radio button option")]
        public void ThenUserSelectsRoutesWithLeastWalkingRadioButtonOption()
        {
            journeyPlannerWidgetPage.SelectLeastWalkingOption();    
        }

        [Then(@"User clicks the Update journey button")]
        public void ThenUserClicksTheUpdateJourneyButton()
        {
            journeyPlannerWidgetPage.ClickUpdateJourneyButton();
        }

        [Then(@"the journey time should be displayed")]
        public void ThenTheJourneyTimeShouldBeDisplayed()
        {
            Assert.That(journeyPlannerWidgetPage.IsUpdatedJourneyTimeDisplayed(), Is.True);

        }

        [Then(@"User click on the View details button")]
        public void ThenUserClickOnTheViewDetailsButton()
        {
            journeyPlannerWidgetPage.ClickViewDetailsButton();
        }

        [Then(@"User click on the Accessibility details link")]
        public void ThenUserClickOnTheAccessibilityDetailsLink()
        {
            journeyPlannerWidgetPage.ClickAccessibilityDetailsLink();   
        }

        [Then(@"the complete access information at Covent Garden Underground Station should be displayed")]
        public void ThenTheCompleteAccessInformationAtCoventGardenUndergroundStationShouldBeDisplayed()
        {
            Assert.That(journeyPlannerWidgetPage.IscompleteAccessInformationDisplayed(), Is.True);

        }

      

        [When(@"User clicks the Plan my journey button")]
        public void WhenUserClicksThePlanMyJourneyButton()
        {
            journeyPlannerWidgetPage.ClickPlanMyJourneyButton();    
        }

        [Then(@"User gets an ""([^""]*)""")]
        public void ThenUserGetsAn(string errorMessage)
        {
            Assert.That(journeyPlannerWidgetPage.IsInvalidJourneyErrorMessageDisplayed(), Is.True);

        }


        [When(@"User leaves the From field text box blank")]
        public void WhenUserLeavesTheFromFieldTextBoxBlank()
        {
            journeyPlannerWidgetPage.ClearBlankStartLocationTxtBox();   
        }

        [When(@"User leaves the To field text box blank")]
        public void WhenUserLeavesTheToFieldTextBoxBlank()
        {
            journeyPlannerWidgetPage.ClearEndStartLocationTxtBox();
        }

        [Then(@"error messages The From field is required and The To field is required are displayed")]
        public void ThenErrorMessagesTheFromFieldIsRequiredAndTheToFieldIsRequiredAreDisplayed()
        {
            Assert.That(journeyPlannerWidgetPage.IsFromFieldIsRequiredErrMsgDisplayed(), Is.True);
            Assert.That(journeyPlannerWidgetPage.IsToFieldIsRequiredErrMsgDisplayed(), Is.True);

        }
    }
}
