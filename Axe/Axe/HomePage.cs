using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using FluentAssertions;
using OpenQA.Selenium;
using Selenium.Axe;

namespace Axe
{
    internal class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void GoTo()
        {
            driver.Navigate().GoToUrl("https://osi.provata-us-qa.devops-staywell.com");
        }

        internal void Login()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/header/nav[2]/ul/li[1]/a")).Click();
            Thread.Sleep(2000);
            _ = driver.FindElement(By.Id("email")).Displayed;
            driver.FindElement(By.Id("email")).SendKeys("*******");

            driver.FindElement(By.Id("password")).SendKeys("******!");
            driver.FindElement(By.XPath("//*[@id='react']/div/div[1]/main/section/div/div/div[2]/form/section[4]/button")).Click();
            Thread.Sleep(6000);
            _ = driver.FindElement(By.XPath("//*[@id='react']/div/header/nav/ul/li[1]/a/span")).Displayed;

        }

        internal void AxeScanBasic()
        {
            //AxeResult results = driver.Analyze();
            //results.Violations.Should().BeEmpty();
            //Console.WriteLine(results);
        }

        internal void AxeScanLevelA()
        {
            var results = new AxeBuilder(driver)
                .WithTags("wcag2a")
                .Analyze();
            results.Violations.Should().BeEmpty();
            Console.WriteLine(results);
        }

        internal void AxeScanLevelAA()
        {
            var results = new AxeBuilder(driver)
                .WithTags("wcag21aa")
                .Analyze();
            results.Violations.Should().BeEmpty();
            Console.WriteLine(results);
        }

        internal void AxeScanLevelAAA()
        {
            var results = new AxeBuilder(driver)
                .WithTags("wcag2aaa")
                .Analyze();
            results.Violations.Should().BeEmpty();
            Console.WriteLine(results);
        }
    }
} 
