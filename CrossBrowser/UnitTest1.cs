/*
 * Project:Automated browser testing
 * Author:Sona G
 * Date :18/09/2021
 */
using NUnit.Framework;
using System;
using System.Collections.Generic;
namespace CrossBrowser
{
    [TestFixture]
    [Parallelizable]
    public class Tests : Base.BaseClass
    {
        public static IEnumerable<String> BrowserToRunWith()
        {
            String[] browsers = { "chrome", "firefox" };
            foreach (string b in browsers)
            {
                yield return b;
            }
        }
        
        [Test]
        [TestCaseSource("BrowserToRunWith")]
        public void LoginIntoFacebook(string browsername)
        {
            BrowserTestMethod(browsername);
            Action.ActionClass.LoginPageBrowserTest();
        }
    }
}