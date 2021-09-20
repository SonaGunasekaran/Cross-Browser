/*
 * Project:Automated browser testing
 * Author:Sona G
 * Date :18/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace CrossBrowser.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;


        public void BrowserTestMethod(string browsername)
        {
            if (browsername.Equals("firefox"))
                driver = new FirefoxDriver();
            else
                driver = new ChromeDriver();//Launches Browser

            driver.Manage().Window.Maximize();  //Maximize Browser
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
