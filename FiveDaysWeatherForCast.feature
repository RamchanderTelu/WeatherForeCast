Feature: Five Day Weather Fore Cast
   As a user I need to see weather forecast for 5 days starting from today 
   for the selected place (City)

 Background: 
   Given I have open the weather forecast app

@firstTest
Scenario: An option to select/Enter a place 	
	Then I should have a option to select/enter place

Scenario Outline: Five day weather forecast shown for a selected City  
  When I have entered/selected a valid "<City>" 
  Then Five day weather forecast is shown for "<City>" 


Examples: 
| City     |
| Glasgow  |
| Aberdeen |
| London   |




Scenario Outline:  No forecast shown for incorrect city
When I have entered a incorrect "<City>"
Then I don't see any forecast
And I see a error message saying "Error retrieving the forecast"


Examples: 
| City               |
| XYZ                |
| 1234               |
| Glas glow          |
| Aberdeen 3323232   |



Scenario: 3 hourly forecast details expanded for a selected day
Given I have entered/selected a valid city
When I have selected a day 
Then I should see 3 hourly forecase shown for the day

Scenario: 3 hourly forecast details hidden for a selected day
Given I have entered/selected a valid city
And  I have selected a day
When I have reselected the same day
Then I should see that 3 hourly forecast details are hidden

Scenario: 3 hourly forecast details summary
Given I have entered/selected a valid city
And I have selected a day 
Then I have to see the summary for every 3 hours with below details 


Scenario: Able to see forecast when entered a valid city on error page
Given I am on error page 
 When I have entered/selected a valid City
 Then Five day weather forecast is shown 
 
 Scenario Outline: The summary forecase details for a day
  When I have entered/selected a valid City
  Then "<Selection>" is shown for the day 


  Examples: 
  | Selection                        |
  | Most dominant condition          |
  | Current wind speed and direction |
  | Aggregate rainfall               |
  | Minimum and maximum temperatures |
 

 Scenario Outline: The summary forecase details for 3 hourly
  When I have entered/selected a valid City
  And  I have selected a day
  Then "<Selection>" is shown for every 3 hours


  Examples: 
  | Selection                        |
  | Most dominant condition          |
  | Current wind speed and direction |
  | Aggregate rainfall               |
  | Minimum and maximum temperatures |
 
 Scenario: Rounded values shown in  day forecast
     
  When I have entered/selected a valid City 
  Then Values shown are rounded

  Scenario: Rounded values shown in 3 hourly forecast
     
  When I have entered/selected a valid City
  And  I have selected a day
  Then Values shown are rounded


  Scenario: Previously selected day's 3 hourly forecast is Hidden when day is selected
  Given I have entered/selected a valid city
  And  I have selected a <Day>
  When I have selected the someother <Day2>
  Then I should see that 3 hourly forecast details for lastly select <Day2> 
  And I should see that 3 hourly forecast details are hidden for <Day1> 
  
  
 
 
 