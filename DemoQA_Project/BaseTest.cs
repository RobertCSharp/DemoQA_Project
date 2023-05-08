using DemoQA_Project.Data;
using DemoQA_Project.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Extensions;

namespace DemoQA_Project
{
    public class BaseTest
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Constants.URL);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void LoginTest()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login();
            string expectedUserName = Constants.UserName;

            HomePage homePage = new HomePage(driver);
            string actualUserName = homePage.GetUserName();

            Assert.That(actualUserName, Is.EqualTo(expectedUserName));
        }

        [Test]
        public void AddBookToCollectionTest()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login();
            Thread.Sleep(1000);
            BasePage basePage = new BasePage(driver);
            basePage.ScrollDown();
            HomePage homePage = new HomePage(driver);
            homePage.SelectBook();
            basePage.WaitInSeconds(2);
            basePage.ScrollDown();
            Thread.Sleep(2000);
            homePage.AddBookToCollection();
            basePage.CloseAlert();
            homePage.ScrollToProfile();
            homePage.ClickToProfile();
            homePage.LoginOut();
        }
    }
}