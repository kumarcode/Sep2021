using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using September2021.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace September2021.Pages
{
    class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            // launch turn up portal and maximize window
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            try
            {
                // indetify the username textbox enter valid username
                IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
                usernameTextbox.SendKeys("hari");

                // identify password textbox enter valid password
                IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
                passwordTextbox.SendKeys("123123");

                // identify login button and click
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();
                Thread.Sleep(1500);
            }
            catch(Exception ex)
            {
                Assert.Fail("TurnUp portal home page did not launch", ex.Message);
            }

        }
    }
}
