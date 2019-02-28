using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Csharp_Selenium_training
{
    public class PageObject
    {   

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement DdlTitleId { get; set; }

        [FindsBy(How=How.Name, Using = "Initial")]
        public IWebElement TxtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement BtnSave { get; set; }

        public PageObject()
        { // for initialing the proporities, we need a constructore
            PageFactory.InitElements(PropretiesCollection.driver,this);
        }
    }
}
