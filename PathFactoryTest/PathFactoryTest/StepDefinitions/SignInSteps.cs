using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using PathFactoryTest.Pages;
using PathFactoryTest.Utilities;
using TechTalk.SpecFlow;

namespace PathFactoryTest.StepDefinitions
{
    [Binding]
    public class SignInSteps : BrowserDriver
    {
        App app = new App();

        [Given(@"I am in Sign In page")]
        public void GivenIAmInSignInPage()
        { 
            // Click sign in button to naviagate to page
            app.basePage(driver).SignIn.Click();

            // Verify page loaded
            Assert.AreEqual("Login - My Store", driver.Title, "Did not navigate to sign in page");
        }

        [When(@"I enter valid email address '(.*)'")]
        [When(@"I enter invalid email address '(.*)'")]
        public void WhenIEnterInvalidEmailAddress(string emailId)
        {
            // Enter emailId 
            app.signInPage(driver).EmailAddress.SendKeys(emailId);

            // Enter tab to perform action
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Tab).Build().Perform();
        }

        [Then(@"email address field should be highlighted red as warning")]
        public void ThenEmailAddressFieldShouldBeHighlightedRedAsWarning()
        {
            // Class used for identifying highlighted text field
            string className = "form-group form-error";

            // Verify 
            Assert.AreEqual(className, app.signInPage(driver).EmailAddressBorder.GetAttribute("class"), "Email field not highlighted with Red border");
        }

        [Then(@"email address field should be highlighted in green")]
        public void ThenEmailAddressFieldShouldBeHighlightedInGreen()
        {
            // Class used for identifying highlighted text field
            string className = "form-group form-ok";           

            // Verify 
            Assert.AreEqual(className, app.signInPage(driver).EmailAddressBorder.GetAttribute("class"), "Email field not highlighted with Red border");
        }

        [When(@"I click on Sign in button")]
        public void WhenIClickOnSignInButton()
        {
            app.signInPage(driver).SignIn.Click();
        }

        [Then(@"a warning message should be shown '(.*)'")]
        public void ThenAWarningMessageShouldBeShown(string warningMessage)
        {
            // Verify 
            Assert.AreEqual(warningMessage, app.signInPage(driver).ErrorMessage.Text, "Error message not valid");
        }

        [When(@"I enter a password '(.*)'")]
        public void WhenIEnterAPassword(string password)
        {
            // Enter password 
            app.signInPage(driver).Password.SendKeys(password);
        }

        [When(@"I enter valid emailid '(.*)' and password '(.*)'")]
        public void WhenIEnterValidEmailidAndPassword(string emailId, string password)
        {
            WhenIEnterInvalidEmailAddress(emailId);
            WhenIEnterAPassword(password);
        }

        [Then(@"I am on My account section")]
        public void ThenIAmOnMyAccountSection()
        {
            // Verify page loaded
            Assert.AreEqual("My account - My Store", driver.Title, "Did not navigate to My account page");
        }

        [Then(@"I am on Forgot your password page")]
        public void ThenIAmOnForgotYourPasswordPage()
        {
            // Verify page loaded
            Assert.AreEqual("Forgot your password - My Store", driver.Title, "Did not navigate to My account page");
        }

        [When(@"I click on Forgot password link")]
        public void WhenIClickOnForgotPasswordLink()
        {
            app.signInPage(driver).ForgotPassword.Click();
        }







    }
}
