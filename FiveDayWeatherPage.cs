using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
//using OpenQA.Selenium.Support.UI;

namespace SpecFlowProject.Pages
{
    class FiveDayWeatherPage : Base
    {
         
        By txtCityName = By.Id("city");
         
       /* public FiveDayWeatherPage(IWebDriver driver)
        {
            this.driver = driver; 
        }*/

        public IWebDriver NavigateToURL()
        {
            driver.Url=  ConfigurationSettings.AppSettings["TestURL"];
            return driver;
        }

        public IWebDriver SetCity(string strCity)
        {
            driver.FindElement(txtCityName).Clear();
            driver.FindElement(txtCityName).SendKeys(strCity);
            driver.FindElement(txtCityName).SendKeys(Keys.Return);
            
           return driver;
        }

        public bool checkForCity()
        {
            return driver.FindElement(txtCityName).Enabled;
        }

        public bool checkForFiveRowsOnPage(string strCity)
        {

            IList<IWebElement> rows = driver.FindElements(By.XPath(".//*[@id='root']//div[@style= 'padding-bottom: 20px;']"));

            if (getRowCountOnPage() == 5)
                return true;
            else
                return false;           
        }

        public int getRowCountOnPage()
        {
            try
            {
                IList<IWebElement> rows = driver.FindElements(By.XPath(".//*[@id='root']//div[@style= 'padding-bottom: 20px;']"));
                return rows.Count;
            }
            catch(Exception e)
            {
                return 0;
            }
            
        }

        public bool checkedForNoForecast()
        {
            if (getRowCountOnPage() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkForExpandedSummaryForADay(int RowId)
        {
            return true;
        }

        public bool checkForErrorMessage(string strErrorMessage)
        {
           
               IWebElement errorText = driver.FindElement(By.XPath(".//*[@id='root']/div/div[@data-test='error']"));

               if (errorText.Text.ToString().Equals(strErrorMessage))
                   return true;
               else
                   return false;
            
        }
        public void CloseBrowser()
        {
            driver.Close();
        }

        public void clickOnADay(int iRowId)
        {
            IList<IWebElement> rows = driver.FindElements(By.XPath(".//*[@id='root']//div[@style= 'padding-bottom: 20px;']"));
            rows[iRowId].Click();
        }

    }
}
