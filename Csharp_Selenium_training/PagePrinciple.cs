using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Csharp_Selenium_training
{
    public class PagePrinciple
    {   

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement DdlTitleId { get; set; }

        [FindsBy(How=How.Id, Using = "Initial")]
        public IWebElement TxtInitial { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement TxtFirstName { get; set; }


        [FindsBy(How = How.Id, Using = "MiddleName")]
        public IWebElement TxtMiddleName { get; set; }

      

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement BtnSave { get; set; }

        public PagePrinciple()
        { // for initialing the proporities, we need a constructore
            PageFactory.InitElements(PropretiesCollection.driver,this);
        }

        public void SaveInfo(string initial,string firstName, string midleName)
        {
            this.TxtInitial.SendKeys(initial);
            this.TxtFirstName.SendKeys(firstName);
            this.TxtMiddleName.SendKeys(midleName);
            this.BtnSave.Click();
        }
    }
}
