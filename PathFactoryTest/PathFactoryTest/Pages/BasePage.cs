using OpenQA.Selenium;

namespace PathFactoryTest.Pages
{
    public class BasePage
    {
        private IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement SignIn
        {
            get { return driver.FindElement(By.CssSelector("a.login")); }
        }


        public IWebElement SignOut
        {
            get { return driver.FindElement(By.CssSelector("a.logout")); }
        }

    }
}
