using OpenQA.Selenium;

namespace PathFactoryTest.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement SignIn
        {
            get { return driver.FindElement(By.CssSelector("a.login")); }
        }

        
    }
}
