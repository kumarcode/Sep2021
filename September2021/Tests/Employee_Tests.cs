using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using September2021.Pages;
using September2021.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace September2021.Tests
{
    [TestFixture]
    [Parallelizable]
    class Employee_Tests : CommonDriver
    {
      
        [Test, Order(1), Description("Check if user is able to create Employee record with valid data")]
        public void CreateEmployeeTest()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            // TM page object initialization and definition
            EmployeesPage employeeObj = new EmployeesPage();
            employeeObj.CreateEmployee(driver);
        }
        [Test, Order(2), Description("Check if user is able to edit Employee record with valid data")]
        public void EditEmployeeTest()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            // Edit time
            EmployeesPage employeeObj = new EmployeesPage();
            employeeObj.EditEmployee(driver);
        }

        [Test, Order(3), Description("Check if user is able to delete Employee record")]
        public void DeleteEmployeeTest()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            // Delete time
            EmployeesPage employeeObj = new EmployeesPage();
            employeeObj.DeleteEmployee(driver);
        }

    }
}
