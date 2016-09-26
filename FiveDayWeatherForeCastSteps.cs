using System;
using System.Configuration;
using TechTalk.SpecFlow;
using SpecFlowProject.Pages;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlowProject
{
    [Binding]
    public class FiveDayWeatherForeCastSteps
    {
        IWebDriver driver;
        FiveDayWeatherPage fDWPage;  
        [Given (@"I have open the weather forecast app")]
        public void GivenIHaveOpenedWeatherForecastApp()
        {
            fDWPage = new FiveDayWeatherPage();
            driver = fDWPage.OpenBrowser(ConfigurationSettings.AppSettings["Browser"]);
            fDWPage.NavigateToURL();           
            ScenarioContext.Current.Add("fDWPage", fDWPage);  
        }
        [Given(@"I have entered/selected a valid city")]
        public void GivenIHaveEnteredSelectedAValidCity(string strCity)
        {
            var fDWPage = (FiveDayWeatherPage)ScenarioContext.Current["fDWPage"];
            fDWPage.SetCity(strCity);
            ScenarioContext.Current.Add("fDWPage", fDWPage); 
        }
        
        [Given(@"I have selected a day")]
        public void GivenIHaveSelectedADay()
        {
            var fDWPage = (FiveDayWeatherPage)ScenarioContext.Current["fDWPage"];
            fDWPage.clickOnADay(1);
        }

        
        [Given(@"I am on error page")]
        public void GivenIAmOnErrorPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have selected a (.*)")]
        public void GivenIHaveSelectedA(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I have selected a day")]
        public void WhenIHaveSelectedADay()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I have reselected the same day")]
        public void WhenIHaveReselectedTheSameDay()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I have entered/selected a valid ""(.*)""")]
        public void WhenIHaveEnteredSelectedAValid(string strCity)
        {
            var fDWPage = (FiveDayWeatherPage)ScenarioContext.Current["fDWPage"];
            fDWPage.SetCity(strCity);
           // ScenarioContext.Current.Add("fDWPage", fDWPage); 
        }
        
       
        [When(@"I have entered a incorrect ""(.*)""")]
        public void WhenIHaveEnteredAIncorrect(string strCity)
        {
            var fDWPage = (FiveDayWeatherPage)ScenarioContext.Current["fDWPage"];
            fDWPage.SetCity(strCity);
        }
        
        [When(@"I have entered/selected a valid City")]
        public void WhenIHaveEnteredSelectedAValidCity()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I have selected the someother (.*)")]
        public void WhenIHaveSelectedTheSomeother(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should have a option to select/enter place")]
        public void ThenIShouldHaveAOptionToSelectEnterPlace()
        {
            var fDWPage =  (FiveDayWeatherPage) ScenarioContext.Current["fDWPage"];
            Assert.IsTrue(fDWPage.checkForCity());    
        }
        
        [Then(@"I should see (.*) hourly forecase shown for the day")]
        public void ThenIShouldSeeHourlyForecaseShownForTheDay(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see that (.*) hourly forecast details are hidden")]
        public void ThenIShouldSeeThatHourlyForecastDetailsAreHidden(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I have to see the summary for every (.*) hours with below details")]
        public void ThenIHaveToSeeTheSummaryForEveryHoursWithBelowDetails(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Five day weather forecast is shown for ""(.*)""")]
        public void ThenFiveDayWeatherForecastIsShownFor(string strCity)
        {
            var fDWPage = (FiveDayWeatherPage)ScenarioContext.Current["fDWPage"];
            Assert.IsTrue(fDWPage.checkForFiveRowsOnPage(strCity));
        }
        
        [Then(@"I don't see any forecast")]
        public void ThenIDonTSeeAnyForecast()
        {
            var fDWPage = (FiveDayWeatherPage)ScenarioContext.Current["fDWPage"];
            Assert.IsTrue(fDWPage.checkedForNoForecast());
        }
        
        [Then(@"I see a error message saying ""(.*)""")]
        public void ThenISeeAErrorMessageSaying(string strErrorMessage)
        {
            var fDWPage = (FiveDayWeatherPage)ScenarioContext.Current["fDWPage"];
            Assert.IsTrue(fDWPage.checkForErrorMessage(strErrorMessage));
        }
        
        [Then(@"Five day weather forecast is shown")]
        public void ThenFiveDayWeatherForecastIsShown()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"""(.*)"" is shown for the day")]
        public void ThenIsShownForTheDay(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"""(.*)"" is shown for every (.*) hours")]
        public void ThenIsShownForEveryHours(string p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Values shown are rounded")]
        public void ThenValuesShownAreRounded()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see that (.*) hourly forecast details for lastly select (.*)")]
        public void ThenIShouldSeeThatHourlyForecastDetailsForLastlySelect(int p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see that (.*) hourly forecast details are hidden for (.*)")]
        public void ThenIShouldSeeThatHourlyForecastDetailsAreHiddenFor(int p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var fDWPage = (FiveDayWeatherPage)ScenarioContext.Current["fDWPage"];
            fDWPage.CloseBrowser();
        }

    }
}
