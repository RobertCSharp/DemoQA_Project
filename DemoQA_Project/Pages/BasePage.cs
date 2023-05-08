using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace DemoQA_Project.Pages
{
    public class BasePage
    {
        IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ScrollDown()
        {
            driver.ExecuteJavaScript("window.scroll(0,950)");
        }

        public void WaitInSeconds(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        public void CloseAlert()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
    }
}
