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
       

        static void Main(string[] args)
        {
            {

            }
        }
               
        [SetUp] // for calling the methode Initialize() immediately before each test
        public void Initialize()
        {   
            // the driver defined as statis in ProperitiesCollection class is instntiated here
            PropretiesCollection.driver = new ChromeDriver();

            // navigate to google chrome
            PropretiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
            Console.WriteLine("the url is openned");
        }


        [Test]
        public void ExecuteTest()
        {
            SeleniumSetMethods.SelectDropDown( "TitleId", "Ms.", "Id");
            SeleniumSetMethods.EnterText( "Initial", "salam", "Name");
            Console.WriteLine(SeleniumGetMethods.GetTextDDL( "TitleId", "Id"));
            Console.WriteLine(SeleniumGetMethods.GetText( "Initial", "Name"));
            SeleniumSetMethods.Click( "Save", "Name");


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
            PropretiesCollection.driver.Close();
            Console.WriteLine("the brower is closed!");
        }

    }
}
