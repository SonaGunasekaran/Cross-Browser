/*
 * Project:Automated browser testing
 * Author:Sona G
 * Date :18/09/2021
 */
using OpenQA.Selenium;

namespace CrossBrowser.Action
{
    public class ActionClass :Base.BaseClass
    {
        
        public  static void LoginPageBrowserTest()
        {
            driver.Url = "https://www.facebook.com/";
            driver.FindElement(By.Name("email")).SendKeys("santydx5@gmail.com");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Id("pass")).SendKeys("Santhosh23");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("login")).Click();
            System.Threading.Thread.Sleep(10000);
        }
    }
}
