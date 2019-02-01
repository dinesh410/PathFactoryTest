using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace PathFactoryTest.Utilities
{
    public class BrowserDriver
    {
        public static IWebDriver driver;

        public static void InitializeDriver()
        {
            //Create a new instance of the chrome driver 
            driver = new ChromeDriver();

            //Create a new instance of the firefox driver  
            //driver = new FirefoxDriver();                       
        }
    }
 
}
