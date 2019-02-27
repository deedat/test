using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Csharp_Selenium_training
{
    // since it is a library, we use static methods



    class SeleniumSetMethods
    {   //SET METHODS


        //1. Method for entring a text
        public static void EnterText(IWebDriver driver, string elementValue, string value, string elementType)
        {
            if (elementType== "Id")
            {
                driver.FindElement(By.Id(elementValue)).SendKeys(value);
            }

            if (elementType == "Name")
            {
                driver.FindElement(By.Name(elementValue)).SendKeys(value);
            }
        }


        //2. Method for clicking a button
        public static void Click(IWebDriver driver, string elementValue, string elementType)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(elementValue)).Click();
            }

            if (elementType == "Name")
            {
                driver.FindElement(By.Name(elementValue)).Click();
            }
        }

        //3.  Method for selection from drop down menu
        public static void SelectDropDown(IWebDriver driver , string elementValue, string value, string elementType)
        {
            //To deal with Drop/Down List, we use a class called SelectElement
            // add a package "*support.classes" in : tool->extentions and update

            if (elementType == "Id")
            {
                new SelectElement(driver.FindElement(By.Id(elementValue))).SelectByText(value);
            }

            if (elementType == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(elementValue))).SelectByText(value);
            }
        }

    }
}
