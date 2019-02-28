using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace Csharp_Selenium_training
{
    class SeleniumGetMethods
    {
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");

        }



        public static string GetTextDDL(IWebElement element)
        {

            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}