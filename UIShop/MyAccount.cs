using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIShop
{
    internal class MyAccount
    {
        IWebDriver webDriver;
        [SetUp]
        public void StartChrome()
        {
            webDriver = new ChromeDriver(".");
            webDriver.Url = "http://shop.demoqa.com/";
            webDriver.FindElement(By.XPath("/html/body/p/a")).Click();
        }
        [Test, Category("My Account")]
        public void VerifyMyAccountSection()
        {
            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[2]/a")).Click();
            webDriver.FindElement(By.Id("username")).SendKeys("pnrkouwsohyhlgaavs@bvhrk.com");
            webDriver.FindElement(By.Id("password")).SendKeys("Pineapple250590");
            webDriver.FindElement(By.Name("login")).Click();
            webDriver.FindElement(By.XPath("/html/body/div[1]/header/div[2]/div/div/div/div/a/img")).Click();


            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[2]/a")).Click();

            IWebElement dashboard = webDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/main/article/div/div/nav/ul/li[1]/a"));
            Boolean dashboardDisplayed = dashboard.Displayed;
            IWebElement orders = webDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/main/article/div/div/nav/ul/li[2]/a"));
            Boolean ordersDisplayed = orders.Displayed;
            IWebElement downloads = webDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/main/article/div/div/nav/ul/li[3]/a"));
            Boolean downloadDisplayed = downloads.Displayed;
            IWebElement addressed = webDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/main/article/div/div/nav/ul/li[4]/a"));
            Boolean addressesDisplayed = addressed.Displayed;
            IWebElement favorites = webDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/main/article/div/div/nav/ul/li[48]/a"));
            Boolean favoritesDisplayed = favorites.Displayed;
            IWebElement accountDetails = webDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/main/article/div/div/nav/ul/li[6]/a"));
            Boolean accountDetailsDisplayed = accountDetails.Displayed;
            IWebElement logout = webDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/main/article/div/div/nav/ul/li[6]/a"));
            Boolean logoutDisplayed = logout.Displayed;

            Assert.Pass();
        }
        [TearDown]
        public void Close()
        {
            webDriver.Close();
        }
    }
}
