using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIShop
{
    internal class AddProductToCart
    {
        IWebDriver webDriver;
        [SetUp]
        public void StartChrome()
        {
            webDriver = new ChromeDriver(".");
            webDriver.Url = "http://shop.demoqa.com/";
            webDriver.FindElement(By.XPath("/html/body/p/a")).Click();
        }
        [Test, Category("Navigation bar")]
        public void VerifyUserManagementSectionWithNotLoggedUser()
        {

            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[2]/a")).Click();
            IWebElement registerForm = webDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/main/article/div/div/div[2]/div[2]"));
            //fall or assert
            Assert.Pass();
        }
        [Test, Category("Navigation bar")]
        public void VerifyNavigationBarSectionsWithNotLoggedUser()
        {
            IWebElement myWishList = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[1]/a"));
            Boolean myWishList_enabled = myWishList.Enabled;
            IWebElement myAccount = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[2]/a"));
            Boolean myAccount_enabled = myAccount.Enabled;
            IWebElement checkOut = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[3]/a"));
            Boolean checkOut_enabled = checkOut.Enabled;
            IWebElement searchField = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[2]/div/a"));
            Boolean searchField_enabled = searchField.Enabled;
            IWebElement email = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[1]/li[1]/a"));
            Boolean email_enabled = email.Enabled;
            IWebElement telephone = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[1]/li[2]/a"));
            Boolean telephone_enabled = telephone.Enabled;
            IWebElement cart = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[2]/div/ul/li/a/span/span[2]"));
            Boolean cart_enabled = cart.Enabled;

            Assert.Pass();
        }
        [Test, Category("Navigation bar")]
        public void VerifyNavigationBarSectionsWithLoggedInUser()
        {
            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[2]/a")).Click();
            webDriver.FindElement(By.Id("username")).SendKeys("pnrkouwsohyhlgaavs@bvhrk.com");
            webDriver.FindElement(By.Id("password")).SendKeys("Pineapple250590");
            webDriver.FindElement(By.Name("login")).Click();
            webDriver.FindElement(By.XPath("/html/body/div[1]/header/div[2]/div/div/div/div/a/img")).Click();

            IWebElement myWishList = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[1]/a"));
            Boolean myWishList_enabled = myWishList.Enabled;
            IWebElement myAccount = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[2]/a"));
            Boolean myAccount_enabled = myAccount.Enabled;
            IWebElement checkOut = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[3]/a"));
            Boolean checkOut_enabled = checkOut.Enabled;
            IWebElement searchField = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[2]/div/a"));
            Boolean searchField_enabled = searchField.Enabled;
            IWebElement email = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[1]/li[1]/a"));
            Boolean email_enabled = email.Enabled;
            IWebElement telephone = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[1]/li[2]/a"));
            Boolean telephone_enabled = telephone.Enabled;
            IWebElement cart = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[2]/div/ul/li/a/span/span[2]"));
            Boolean cart_enabled = cart.Enabled;


            Assert.Pass();
        }
        [Test, Category("Navigation bar")]
        public void VerifyCheckoutSectionWithNotLoggedUser()
        {
            IWebElement checkOut = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[3]/a"));
            checkOut.Click();
            //users is redirected to the shoping cart.



            Assert.Pass();
        }
        [Test, Category("Navigation bar")]
        public void VerifyCheckoutSectionWithLoggedInUser()
        {
            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[2]/a")).Click();
            webDriver.FindElement(By.Id("username")).SendKeys("pnrkouwsohyhlgaavs@bvhrk.com");
            webDriver.FindElement(By.Id("password")).SendKeys("Pineapple250590");
            webDriver.FindElement(By.Name("login")).Click();
            webDriver.FindElement(By.XPath("/html/body/div[1]/header/div[2]/div/div/div/div/a/img")).Click();

            IWebElement checkOut = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[3]/a"));
            checkOut.Click();
            //users is redirected to the shoping cart.



            Assert.Pass();
        }
        [TearDown]
        public void Close()
        {
            webDriver.Close();
        }
    }
}
