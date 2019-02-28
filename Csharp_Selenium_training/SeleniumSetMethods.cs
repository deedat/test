using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Csharp_Selenium_training
{

    class SeleniumSetMethods
    {   //SET METHODS


        //1. Method for entring a text
        public static void EnterText( string elementValue, string value, string elementType)
        {
            if (elementType== "Id")
            {
                PropretiesCollection.driver.FindElement(By.Id(elementValue)).SendKeys(value);
            }

            if (elementType == "Name")
            {
                PropretiesCollection.driver.FindElement(By.Name(elementValue)).SendKeys(value);
            }
        }


        //2. Method for clicking a button
        public static void Click( string elementValue, string elementType)
        {
            if (elementType == "Id")
            {
                PropretiesCollection.driver.FindElement(By.Id(elementValue)).Click();
            }

            if (elementType == "Name")
            {
                PropretiesCollection.driver.FindElement(By.Name(elementValue)).Click();
            }
        }

        //3.  Method for selection from drop down menu
        public static void SelectDropDown( string elementValue, string value, string elementType)
        {
            //To deal with Drop/Down List, we use a class called SelectElement
            // add a package "*support.classes" in : tool->extentions and update

            if (elementType == "Id")
            {
                new SelectElement(PropretiesCollection.driver.FindElement(By.Id(elementValue))).SelectByText(value);
            }

            if (elementType == "Name")
            {
                new SelectElement(PropretiesCollection.driver.FindElement(By.Name(elementValue))).SelectByText(value);
            }
        }

    }
}
