using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFactoryTest.Pages
{
    public class App
    {
        public BasePage basePage(IWebDriver driver)
        {
            return new BasePage(driver);
        }

        public HomePage homePage(IWebDriver driver)
        {
            return new HomePage(driver);
        }
        public SignInPage signInPage(IWebDriver driver)
        {
            return new SignInPage(driver);
        }

        public BasePage myAccountPage(IWebDriver driver)
        {
            return new BasePage(driver);
        }
        
    }
}
