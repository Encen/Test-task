using NUnit.Framework;
using TechTalk.SpecFlow;
using Test_task.Config;
using Test_task.PageObject;

namespace Test_task
{
    [Binding, Scope(Feature = "Verify that user can ensure that Rozetka can deliver product anywhere in Ukraine")]
    internal class Test:Helper
    {
        RozetkaMainPage MainPage;
        [When(@"I open the main page of Rozetka")]
        public void WhenIOpenTheMainPageOfRozetka()
        {
            MainPage = new RozetkaMainPage();
            MainPage.OpenMainPage();
        }

        [Then(@"I can see an appropriate message about delivery in Ukraine")]
        public void ThenICanSeeAnAppropriateMessageAboutDeliveryInUkraine()
        {
            bool isElementPresent = MainPage.IsElementPresent();
            Assert.IsTrue(isElementPresent);
        }
    }
}