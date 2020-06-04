using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Test_task.Config
{
    class DriverConfig
    {
        public static IWebDriver GetDriver(DriverTypes driverName)
             => driverName switch
             {
                 DriverTypes.Chrome => new ChromeDriver(),
                 DriverTypes.Firefox => new FirefoxDriver(),
                 _ => new ChromeDriver()
             };
    }
}
