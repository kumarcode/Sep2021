using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace September2021.Pages
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Click on "Create New" button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            // Select Time from "Type Code" dropdown list
            IWebElement typeCodeDropdwon = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdwon.Click();

            IWebElement selectTime = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            selectTime.Click();

            // Indentify "Code" textbox and input code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("September2021");

            // Indetify "Description" textbox and input description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("September2021");

            // Identify "Price per unit" textbox and input price
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();

            IWebElement pricePerUnitTextbox = driver.FindElement(By.Id("Price"));
            pricePerUnitTextbox.SendKeys("12");

            // Click on "Save" button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(5000);

            // Assert that Time record has been created
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            // Assertion
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement newTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            // Assertion
            Assert.That(newCode.Text == "September2021", "Actual Code and expected code do not match.");
            Assert.That(newTypeCode.Text == "T", "Actual TypeCode and expected tyecode do not match.");
            Assert.That(newDescription.Text == "September2021", "Actual Description and expected description do not match.");
            Assert.That(newPrice.Text == "$12.00", "Actual Price and expected price do not match.");


            // option 2

            //if (timeRecord.Text == "September2021")
            //{
            //    Assert.Pass("Time record created successfully, test passed.");
            //}
            //else
            //{
            //    Assert.Fail("Test failed.");
            //}
        }

        public void EditTM(IWebDriver driver)
        {
            // Go to the last page where new record created will be
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findRecordCreated.Text == "September2021")
            {
                // Click on the Edit Button
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
                Thread.Sleep(2000);

                // Click on "TypeCode" from dropdown list and set the Type Code
                IWebElement typeCodeDropdown1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
                typeCodeDropdown1.Click();
                Thread.Sleep(2000);

                IWebElement selectMaterial = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
                selectMaterial.Click();
                Thread.Sleep(2000);

                // Click on "Code" from Textbox and set the code
                IWebElement codeTextBox1 = driver.FindElement(By.Id("Code"));
                codeTextBox1.Clear();
                codeTextBox1.SendKeys("Automated Script1");
                Thread.Sleep(2000);

                // Click on "Description" from Textbox and set the description
                IWebElement descriptionTextBox1 = driver.FindElement(By.Id("Description"));
                descriptionTextBox1.Clear();
                descriptionTextBox1.SendKeys("Automated Script1 is changed");
                Thread.Sleep(2000);

                // Click on "Price per unit" textbox and clear the price
                IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
                priceTag.Click();
                Thread.Sleep(2000);

                IWebElement pricePerUnit1 = driver.FindElement(By.Id("Price"));
                pricePerUnit1.Clear();
                Thread.Sleep(2000);

                priceTag.Click();
                Thread.Sleep(2000);

                // IWebElement pricePerUnit2 = testDriver.FindElement(By.Id("Price"));
                pricePerUnit1.SendKeys("170.00");
                Thread.Sleep(2000);

                // Click on "Save" button
                IWebElement saveButton1 = driver.FindElement(By.Id("SaveButton"));
                saveButton1.Click();
                Thread.Sleep(5000);

                // Assert that Time record has been edited.
                IWebElement goToLastPageBtn1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                goToLastPageBtn1.Click();

                IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                IWebElement newTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
                IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
                IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

                // Assertion
                Assert.That(newCode.Text == "Automated Script1", "Actual Code and expected code do not match.");
                Assert.That(newTypeCode.Text == "M", "Actual TypeCode and expected tyecode do not match.");
                Assert.That(newDescription.Text == "Automated Script1 is changed", "Actual Description and expected description do not match.");
                Assert.That(newPrice.Text == "$170.00", "Actual Price and expected price do not match.");
            }
            else
            {
                Assert.Fail("Record to be edited hasn't been found. Record not edited.");
            }

        }

        public void DeleteTM(IWebDriver driver)
        {
            // Go to the last page where edited record will be
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findEditedRecord.Text == "Automated Script1")
            {

                // Click on the Delete Button
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(5000);

                driver.SwitchTo().Alert().Accept();

                // Assert that Time record has been deleted.
                IWebElement goToLastPageBtn1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                goToLastPageBtn1.Click();
                Thread.Sleep(2000);

                IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                IWebElement editedTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
                IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
                IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

                // Assertion
                Assert.That(editedCode.Text != "Automated Script1", "Code record hasn't been deleted.");
                Assert.That(editedTypeCode.Text != "M", "TypeCode record hasn't been deleted.");
                Assert.That(editedDescription.Text != "Automated Script1 is changed", "Description record hasn't been deleted.");
                Assert.That(editedPrice.Text != "$170.00", "Price record hasn't been deleted.");

            }
            else
            {
                Assert.Fail("Record to be deleted hasn't been found. Record not deleted.");
            }
        


        }
    }
}
