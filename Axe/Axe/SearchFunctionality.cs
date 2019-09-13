using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Axe;

namespace Axe
{
    [TestClass]
    public class SearchFunctionality
    {
        public IWebDriver Driver { get; private set; }

        //[TestMethod]
        //public void TCID1ScanDashboard()
        //{
        //    HomePage homePage = new HomePage(Driver);
        //    homePage.GoTo();
        //    homePage.AxeScanBasic();
        //}

        [TestMethod]
        public void TCID2ScanPublicPage()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoTo();
            //homePage.Login();
            homePage.AxeScanLevelAA();
        }

        //[TestMethod]
        //public void TCID3ScanPublicPage()
        //{
        //    HomePage homePage = new HomePage(Driver);
        //    homePage.GoTo();
        //    //homePage.Login();
        //    homePage.AxeScanLevelAA();
        //}

        //[TestMethod]
        //public void TCID4ScanPublicPage()
        //{
        //    HomePage homePage = new HomePage(Driver);
        //    homePage.GoTo();
        //    //homePage.Login();
        //    homePage.AxeScanLevelAAA();
        //}

        //[TestMethod]
        //public void TCID2AriaLabels()
        //{
        //    HomePage homePage = new HomePage(Driver);
        //    homePage.GoTo();
        //    homePage.Login();
        //    DashboardPage dashboard = new DashboardPage(Driver);
        //    dashboard.AriaLabelCheck();
        //}

        [TestInitialize]
        public void SetupForEverySingleTestMethod()
        {
            var factory = new WebDriverFactory();
            Driver = factory.Create(BrowserType.Chrome);
        }

        [TestCleanup]
        public void CleanUpAfterEveryTestMethod()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}

