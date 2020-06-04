using OpenQA.Selenium;
using Test_task.Config;

namespace Test_task.PageObject
{
    class RozetkaMainPage
    {
        private IWebDriver driver;
        public RozetkaMainPage()
            => driver = Helper.driver;
        private string RozetkaMainPageURl => "https://rozetka.com.ua/";
        private string xpathOfSearchedElement => "//*[contains(text(), 'Доставка по всей Украине')]";

        public void OpenMainPage()
        => driver.Navigate().GoToUrl(RozetkaMainPageURl);
        public bool IsElementPresent()
        {
            try
            {
                driver.FindElement(By.XPath(xpathOfSearchedElement));
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            return true;
        }
    }
}
