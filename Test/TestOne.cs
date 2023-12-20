using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionTest
{
    [TestFixture]
    internal class TestOne
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            // Set up the Chrome WebDriver
            driver = new ChromeDriver();
        }

        [Test]
        public void LoginToWebsite()
        {
            // Your test code here

            // For demonstration purposes, let's navigate to Google
            driver.Navigate().GoToUrl("http://localhost:3000");

            // Add your test logic, such as finding elements and interacting with the page

            // For example, assert that the title contains "Google"
            Assert.That(driver.Title.Contains("W3.CSS Template"), Is.True, "The title is the write one");

            // For demonstration purposes, sleep for a moment (replace with proper waiting)
            Thread.Sleep(3000);
        }

        [TearDown]
        public void TearDown()
        {
            // Close the browser after the test
            driver.Quit();
        }

    }
}
