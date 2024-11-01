Feature: JourneyPlannerWidget
  As a user of the TFL Journey Planner
  I want to plan a valid journey
  So that I can see  journey results 
  
  Background:
    Given I am on the Journey Planner page

  Scenario: Verify Planning a valid journey
    When User Enters "Leicester" to select station for start Journey
    And User enters "Covent" to select station for end Journey
    And User clicks the Plan my journey button.
    Then the journey results should be displayed.
    And the walking and cycling journey times should be displayed.
    And User clicks Edit preferences link
    And User selects Routes with least walking radio button option 
    And User clicks the Update journey button
    Then the journey time should be displayed
    And User click on the View details button
    And User click on the Accessibility details link
    Then the complete access information at Covent Garden Underground Station should be displayed


  Scenario Outline: Verify plan an invalid journey 
    When User Enters invalid "<FromLocation>" to select station for start Journey
    And User enters invalid "<ToLocation>" to select station for end Journey
    And User clicks the Plan my journey button
    Then User gets an "<errorMessage>"

  Examples:
    | FromLocation | ToLocation | errorMessage                                                                |
    | 245678       | 34569#     | Journey planner could not find any results to your search. Please try again |
    | 4r@w}we      | #4ME4LANE  | Journey planner could not find any results to your search. Please try again | 
   
  
   
  Scenario: Verify plan a journey with no locations entered
    When User leaves the From field text box blank
    And User leaves the To field text box blank
    And User clicks the Plan my journey button
    Then error messages The From field is required and The To field is required are displayed

