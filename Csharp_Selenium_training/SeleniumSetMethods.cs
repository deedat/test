using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Csharp_Selenium_training
{

    class SeleniumSetMethods
    {   //SET METHODS


        //1. Method for entring a text
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }


        //2. Method for clicking a button
        public static void Click(IWebElement element)
        {
            element.Click();
        }

        //3.  Method for selection from drop down menu
        public static void SelectDropDown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }

    }
}
