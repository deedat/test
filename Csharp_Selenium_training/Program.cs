using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Selenium_training
{
    class Program
    {
        // create aour referrence to our browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            {

            }
        }
               
        [SetUp] // for calling the methode Initialize() immediately before each test
        public void Initialize()
        {
            // navigate to google chrome
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
            Console.WriteLine("the url is openned");
        }


        [Test]
        public void ExecuteTest()
        {
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Ms.", "Id");
            SeleniumSetMethods.EnterText(driver, "Initial", "salam", "Name");
            Console.WriteLine(SeleniumGetMethods.GetTextDDL(driver, "TitleId", "Id"));
            Console.WriteLine(SeleniumGetMethods.GetText(driver, "Initial", "Name"));
            SeleniumSetMethods.Click(driver, "Save", "Name");


        }

    [Test]// Second test ()
        public void SecondTest()
        {
            Console.WriteLine("the second test");
        }




        [TearDown]
        public void CleanUp()
        {
            //close the brower 
            driver.Close();
            Console.WriteLine("the brower is closed!");
        }

    }
}
