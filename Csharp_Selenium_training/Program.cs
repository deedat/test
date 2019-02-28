using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
            PropretiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");

            Console.WriteLine("the url is openned");
        }


        [Test]
        public void ExecuteTest()
        {



            PageLogin pageLogin = new PageLogin();
            PagePrinciple pagePrinciple = pageLogin.Login("Mohamed", "Password");
            pagePrinciple.SaveInfo("Mohamed", "BENIGHIL","Fahem");








            // it does not work for Drop/Down List (for now)

            // since page.TxtInitial is webelement, we can use sendkeys() methode
            //page.TxtInitial.SendKeys("wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww");

            //page.BtnSave.Click();

            //SeleniumSetMethods.SelectDropDown( "TitleId", "Ms.", PropertyType.Id);
            //SeleniumSetMethods.EnterText( "Initial", "salam", PropertyType.Name);
            //Console.WriteLine(SeleniumGetMethods.GetTextDDL( "TitleId", PropertyType.Id));
            //Console.WriteLine(SeleniumGetMethods.GetText( "Initial", PropertyType.Name));
            //SeleniumSetMethods.Click( "Save", PropertyType.Name);
            
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
