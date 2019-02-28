using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace Csharp_Selenium_training
{
    public static class  SeleniumGetMethods
    {
        public static string GetText(this IWebElement element)
        {
            return element.GetAttribute("value");

        }



        public static string GetTextDDL(this IWebElement element)
        {

            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}