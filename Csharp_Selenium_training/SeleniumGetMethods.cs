using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace Csharp_Selenium_training
{
    class SeleniumGetMethods
    {
        public static string GetText( string nameOrIdContent, string elementType)
        {
            if (elementType == "Id")
            {
                return PropretiesCollection.driver.FindElement(By.Id(nameOrIdContent)).GetAttribute("value");
            }

            if (elementType == "Name")
            {
                return PropretiesCollection.driver.FindElement(By.Name(nameOrIdContent)).GetAttribute("value");
            }
            return string.Empty;
        }



        public static string GetTextDDL( string nameOrIdContent, string elementType)
        {
            if (elementType == "Id")
            {                                                                       //liste             //LINQ           //Text when control with innertext                                
                return new SelectElement(PropretiesCollection.driver.FindElement(By.Id(nameOrIdContent))).AllSelectedOptions.SingleOrDefault().Text;
            }

            if (elementType == "Name")
            {
                return new SelectElement(PropretiesCollection.driver.FindElement(By.Id(nameOrIdContent))).AllSelectedOptions.SingleOrDefault().Text;
            }
            return string.Empty;
        }
    }
}