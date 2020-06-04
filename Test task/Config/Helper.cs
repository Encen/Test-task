using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Test_task.Config
{
    internal class Helper
    {
        internal static IWebDriver driver;
        internal static WebDriverWait wait;
        [BeforeScenario]
        public void SetUp()
        {
            driver = DriverConfig.GetDriver(DriverTypes.Chrome);
            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
        }
        [AfterScenario]
        public void TearDown()
        => driver.Close();
    }
}
