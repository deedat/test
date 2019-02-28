using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace Csharp_Selenium_training
{
    class SeleniumGetMethods
    {
        public static string GetText( string nameOrIdContent, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
            {
                return PropretiesCollection.driver.FindElement(By.Id(nameOrIdContent)).GetAttribute("value");
            }

            if (elementType == PropertyType.Name)
            {
                return PropretiesCollection.driver.FindElement(By.Name(nameOrIdContent)).GetAttribute("value");
            }
            return string.Empty;
        }



        public static string GetTextDDL( string nameOrIdContent, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
            {                                                                       //liste             //LINQ           //Text when control with innertext                                
                return new SelectElement(PropretiesCollection.driver.FindElement(By.Id(nameOrIdContent))).AllSelectedOptions.SingleOrDefault().Text;
            }

            if (elementType == PropertyType.Name)
            {
                return new SelectElement(PropretiesCollection.driver.FindElement(By.Id(nameOrIdContent))).AllSelectedOptions.SingleOrDefault().Text;
            }
            return string.Empty;
        }
    }
}