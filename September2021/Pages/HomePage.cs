using OpenQA.Selenium;
using September2021.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace September2021.Pages
{
    class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            // click on administration dropdown
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();
            Wait.WaitForElementToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 3);


            // select Time & Material from dropdown list
            IWebElement TMdropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TMdropdown.Click();
            Thread.Sleep(2000);
        }

        public void GoToEmployeePage(IWebDriver driver)
        {
            // navigate to employee page
        }
    }
}
