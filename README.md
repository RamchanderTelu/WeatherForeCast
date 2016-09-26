# WeatherForeCast

Sample Acceptance Test was designed in an assumption that testing webUI not the API testing.
Below solution was developed using MSVS 2013 Community Edition, Selenium, SpecFlow.

Sample Acceptance Test Suite contain following files

1. FiveDaysWeatherForcast.feature(Requirement in BDD format)
2. FiveDayWeatherForCastSteps.cs(SpecFlow step definition)
3. Base.cs (Selenium Page Factory Base Class)
4. FiveDayWeatherPage.cs (TestLogic for Five Day Weather Page)
5. App.Config (Test Configuration)

Note: 
1. Tried to cover all E2E scenatios for Weather Forecast App
2. Could only automate 4 scenarios(2 positive and 2 negative) in the given timeframe.

How to run the scripts
1) Download the files 
2) Compile the build locally
3) Run the tests for the report
	a) AnOptionToSelectEnterAPlace
	b) FiveDayWeatherForecastShownForASelectedCity
	c) NoforecastShownForIncorrectCity
     	
