using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQA_Project.Data;
using OpenQA.Selenium;

namespace DemoQA_Project.Pages
{
    public class LoginPage
    {
        IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Login()
        {
            driver.FindElement(By.CssSelector("#login")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(("#userName"))).SendKeys(Constants.UserName);
            driver.FindElement(By.CssSelector(("#password"))).SendKeys(Constants.UserPassword);
            driver.FindElement(By.CssSelector("#login")).Click();
            Thread.Sleep(1000);
        }
    }
}
