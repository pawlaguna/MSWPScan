using System;
using System.Threading;
using OpenQA.Selenium;

namespace Axe
{
    internal class DashboardPage
    {
        private IWebDriver driver;

        private By search = By.ClassName("human-connect");
        private By notifications = By.ClassName("");
        private By levelsAndTeams = By.TagName("current-team-header");



        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void AriaLabelCheck()
        {
            IWebElement syncDevicePop = driver.FindElement(search);
            Console.WriteLine("Label of the button is:- " + syncDevicePop.GetAttribute("aria-label"));

            IWebElement notificationsPop = driver.FindElement(notifications);
            Console.WriteLine("Label of the button is:- " + notificationsPop.GetAttribute("aria-label"));

            IWebElement levelsAndTeamsPop = driver.FindElement(levelsAndTeams);
            Console.WriteLine("Label of the button is:- " + levelsAndTeamsPop.GetAttribute("aria-label"));

            //IWebElement notificationsPop = driver.FindElement(notifications);
            //Console.WriteLine("Label of the button is:-" + notificationsPop.GetAttribute("aria-label"));

        }
    }
}