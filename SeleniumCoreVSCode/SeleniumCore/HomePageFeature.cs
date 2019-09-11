using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumCore
{
    [TestClass]
    public class HomePageFeature
    {
        IWebDriver _driver;

        [TestMethod]
        public void ShouldBeAbleToLogin()
        {            
            _driver.Url = "https://www.saucedemo.com/";

            By loginButtonLocator = By.ClassName("btn_action");

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(
                ExpectedConditions.ElementIsVisible(loginButtonLocator)
            );

            IWebElement usernameField = _driver.FindElement(By.Id("user-name"));
            IWebElement passwordField = _driver.FindElement(By.Id("password"));
            IWebElement logiButton = _driver.FindElement(loginButtonLocator);

            usernameField.SendKeys("standard_user");
            passwordField.SendKeys("secret_sauce");
            logiButton.Click();

            Assert.IsTrue(_driver.Url.Contains("inventory.html"));
        }

        [TestInitialize]
        public void TestInitialize() {
            _driver = new ChromeDriver();
        }

        [TestCleanup]
        public void TestCleanup() {
            _driver.Quit();
        }
    }
}
