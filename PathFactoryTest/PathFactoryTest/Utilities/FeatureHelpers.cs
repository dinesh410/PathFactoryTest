using NUnit.Framework;
using PathFactoryTest.Pages;
using System;
using TechTalk.SpecFlow;

namespace PathFactoryTest.Utilities
{
    [Binding]
    public class FeatureHelpers : BrowserDriver
    {
        App app = new App();

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            InitializeDriver();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();            
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

        }

        [AfterScenario("logout")]
        public void AfterScenario()
        {
            // Click sign in button to naviagate to page
            app.basePage(driver).SignOut.Click();

            // Verify page loaded
            Assert.AreEqual("Login - My Store", driver.Title, "Did not navigate to sign in page");
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            driver.Quit();
        }
    }
}
