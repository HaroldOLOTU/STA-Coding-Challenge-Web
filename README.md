A TfL STA CODING CHALLENGE- WEB: To build a test automation framework with some tests based on the TfL website – Journey Planner widget which is at https://tfl.gov.uk/plan-a-journey
The goal of this coding challenge is to build a stable, scalable, and maintainable automation framework using some of the best practices in automation framework.This framework will address the specified requirements for creating a UI automation framework to validate the functionality of:

1 Verify that a valid journey can be planned using the widget from “Leicester Square Underground Station” to “Covent Garden Underground Station”. (Select value from auto complete suggestions do not enter the complete text)
1a. Validate the result for both walking and cycling time.
2. Once the journey is planned, “Edit preferences”, select routes with least walking, and update journey.
2a. Validate the journey time the "Plan a journey" widget.
3. Click on “View Details”
3a. Verify complete access information at Covent Garden Underground Station.
4. Verify that the widget does not provide results when an invalid journey is planned. (An invalid journey will consist of 1 or more invalid locations entered into the widget).
5. Verify that the widget is unable to plan a journey if no locations are entered into the widget.

This UI automation framework is developed from scratch in Visual Studio. using C# in writing the codes, SpecFlow for behaviour-driven development (BDD) with Gherkin syntax to define test scenarios. The framework uses Selenium WebDriver for automating and interacting with page elements and it’s designed to be extensible, maintainable, and easy to use for running automated UI tests.
The Framework Structure Overview
SpecFlow for Gherkin Syntax: The project will use SpecFlow for Gherkin syntax, making the tests easy to read and understand.
1. Feature File:  Incorporate parameterization and Data-driven to run scenario, steps with different data sets, enhancing test coverage.
2. TestStepDefinition Class: This class uses the SpeFlow and Nunit libraries to bind each feature step to corresponding method in the Page Class. It bridges the human-readable Gherkin language used in feature files and the actual automation that interacts with the application under test. The test logics and Assertions will be implemented in Step definitions class.
3. TestPage Class: The Page object Class is a pattern for code maintainability, usability which handles the actions and the general behaviour of the page. the project will use POM to separate the actions and behaviour of the Page Class from the logic and assertion of the Test Class. Thus, it is easier to fix and maintain when codes change
4 BaseTest ClassWith the BaseTest class set up, each test class that requires browser testing can inherit from BaseTest class. By inheriting, each test will have browser initialization and teardown handled automatically. This is implemented with the NUnit framework. This BaseTest class includes: The JourneyPlannerTests class, for example, will use the Setup and Teardown from BaseTest for browser management, keeping the code modular and reusable.

1. Browser Initialization: A Setup method that initializes the Chrome browser before each test.
2. Tear Down: A Teardown method that quits the driver instance, closing the browser to free up resources 
3. Maximize Browser: Configures the browser to maximize upon start
4. URL Navigation: Opens the https://tfl.gov.uk/plan-a-journey page as the initial URL
5. Accept All Cookies: the code to accept all cookies are handle within the BaseTest class.
6. Synchronization Issues: Sets an implicit wait time of 10 seconds to handle dynamic elements, page actions and behaviour of the page from the Test Step class and interaction from test logic.
Necessary Packages:
1.  NUnit is a popular, open-source testing framework for .NET languages for Annotations to designate methods for Setup and Teardown, for Assertions to verify that codes behave according to expectation, for Data-Driven Testing and parameterization to allow multiple tests input and expected outcomes in a single test method. it provides robust functionality for running, organizing, and reporting tests.
2. Install SpecFlow for behaviour-driven development (BDD) with Gherkin syntax to define test scenarios and Test steps.
3. Install Selenium WebDriver to automate web browser actions
4. Install ChromeDriver A standalone executable that provides Selenium Webdriver the capabilities to automate and control Google Chrome actions.




Development Decision Taken
1 Page Object Model: This pattern promotes code separation and reusability by defining each page in a web application as a class, with its elements and actions encapsulated within that class. So, it is easy to make changes when elements change. Test scripts and page structure are separated, which makes the test code cleaner and more readable. Page classes can be reused across multiple test cases, making it efficient to update tests when the UI changes. Changes to page elements are updated in one place, which automatically update the elements across pages.
2 Data-Driven Testing: allows test data to be separated from test scripts, enabling testers to run the same test scenario multiple times with different sets of data inputs. Allows the reuse of a single test case with multiple data inputs, reducing the need for duplicating test scripts. By testing a wide range of inputs and expected outcomes, data-driven testing helps ensure more thorough test coverage. Changes in test data do not require changes to the test script.
3 DRY (Don’t Repeat Yourself) Principle: principle is a key concept in software development that emphasizes reducing repetition within code to make it more efficient, maintainable, and adaptable. This principle suggests that every piece of knowledge, logic, or functionality in a system should have a single, unambiguous representation. When implemented effectively, DRY ensures that any changes or updates need to be made in only one place, which minimizes redundancy and errors.

Additional Scenarios (Not Automated)
1. Functional Testing:
Validate journey options for multiple transport modes.
Verify journey planner’s results for peak vs. off-peak hours.
Validate that the planner responds accurately to network outages or disruptions.
2. Non-Functional Testing:
Performance: Test response time under heavy traffic.
Usability: Ensure widget is accessible and readable
Security: Check for secure connections and data privacy compliance.
