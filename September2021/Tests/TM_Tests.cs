using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using September2021.Pages;
using September2021.Utilities;
using System;
using System.Threading;

namespace September2021
{
    [TestFixture]
    [Parallelizable]
    class TM_Tests : CommonDriver
    {

        [Test, Order (1), Description("Check if user is able to create Time record with valid data")]
        public void CreateTMTest()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
        }
        [Test, Order (2), Description("Check if user is able to edit Time record with valid data")]
        public void EditTMTest()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // Edit time
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);
        }

        [Test, Order (3), Description("Check if user is able to delete Material record")]
        public void DeleteTMTest()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // Delete time
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);
        }

    }

   

}
