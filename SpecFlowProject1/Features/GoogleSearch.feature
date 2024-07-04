Feature: Google Search
  Scenario: Search for SpecFlow
    Given I am on the Google homepage
    When I search for "SpecFlow"
    Then the first result should contain "SpecFlow"
