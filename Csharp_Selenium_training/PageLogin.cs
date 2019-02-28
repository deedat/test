using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Csharp_Selenium_training
{
    public class PageLogin
    {

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement TxtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement BtnLogin { get; set; }

        public PageLogin()
        {
            PageFactory.InitElements(PropretiesCollection.driver, this);
        }

        public PagePrinciple Login(string username, string password)
        {
            TxtUserName.EnterText(username);
            TxtPassword.EnterText(password);  
            this.BtnLogin.Submit();
            return new PagePrinciple();            
        }
    }
}
