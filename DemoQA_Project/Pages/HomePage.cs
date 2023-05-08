using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_Project.Pages
{
    public class HomePage
    {
        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string GetUserName()
        {
          return driver.FindElement(By.CssSelector(("#userName-value"))).Text;
        }

        public void SelectBook()
        {
            driver.FindElement(By.XPath("//a[@href='/books?book=9781593277574']")).Click();
        }

        public void AddBookToCollection()
        {
            driver.FindElement(By.XPath("(//button[@id='addNewRecordButton'])[2]")).Click();
        }

        public void ScrollToProfile()
        {
            var elem = driver.FindElement(By.XPath("(//span[contains(text(), 'Profile')])"));
            driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", elem);
        }

        public void ClickToProfile()
        {
            driver.FindElement(By.XPath("(//span[contains(text(), 'Profile')])")).Click();
        }

        public void LoginOut()
        {
            driver.FindElement(By.XPath("(//button[@id='submit'])[1]")).Click();
        }
    }
}
