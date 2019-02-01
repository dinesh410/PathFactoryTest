using OpenQA.Selenium;

namespace PathFactoryTest.Pages
{
    public class SignInPage
    {

        private IWebDriver driver;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement EmailAddress
        {
            get { return driver.FindElement(By.CssSelector("input#email")); }
        }

        public IWebElement EmailAddressBorder
        {
            get { return EmailAddress.FindElement(By.XPath("..")); }
        }
        public IWebElement Password
        {
            get { return driver.FindElement(By.CssSelector("input#passwd")); }
        }

        public IWebElement SignIn
        {
            get { return driver.FindElement(By.CssSelector("button#SubmitLogin")); }
        }
        public IWebElement ErrorMessage
        {
            get { return driver.FindElement(By.CssSelector("div[class='alert alert-danger'] ol li")); }
        }

        public IWebElement ForgotPassword
        {
            get { return driver.FindElement(By.CssSelector("a[title='Recover your forgotten password']")); }
        }
    }
}
