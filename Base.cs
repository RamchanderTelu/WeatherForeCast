using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlowProject.Pages
{
    public class Base
    {
        public IWebDriver driver;
        public static Base instance = null;

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit

        public static Base Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Base();
                }
                return instance;
            }
        }


        public IWebDriver OpenBrowser(string strBrowser)
        {
            try
            {

                //String strBrowser = "FireFox";
                if (strBrowser.Equals("FireFox"))
                {
                    //      Console.WriteLine("FireFox Browser");
                    FirefoxProfile firefoxProfile = new FirefoxProfile();
                    FirefoxBinary firefoxBinary = new FirefoxBinary("C:\\Program Files\\Mozilla Firefox\\firefox.exe");
                    driver = new FirefoxDriver(firefoxBinary, firefoxProfile);
                     
                }
                else if (strBrowser.Equals("Chrome"))
                {
                    ChromeOptions chromeOptions = new ChromeOptions();
                    driver = new ChromeDriver("C:\\MyLearningProject\\chromedriver");
                    //   Console.WriteLine("Chrome Browser");
                }
                else if (strBrowser.Equals("IE"))
                {
                      driver = new InternetExplorerDriver();
                }
                else
                {
                    FirefoxProfile firefoxProfile = new FirefoxProfile();
                    FirefoxBinary firefoxBinary = new FirefoxBinary("C:\\Program Files\\Mozilla Firefox\\firefox.exe");
                    driver = new FirefoxDriver(firefoxBinary, firefoxProfile);
                   
                    Console.WriteLine("Incorrect browser configured, so opening default browser");
                }
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            }
            catch (System.ComponentModel.Win32Exception w)
            {
                Console.WriteLine("Issues in navigating to conact page");
                Console.WriteLine(w.Message);
                Console.WriteLine(w.Message);
                Console.WriteLine(w.ErrorCode.ToString());
                Console.WriteLine(w.NativeErrorCode.ToString());
                Console.WriteLine(w.StackTrace);
                Console.WriteLine(w.Source);
                Exception e = w.GetBaseException();

            }

            return driver;

        }
       
    }

}

