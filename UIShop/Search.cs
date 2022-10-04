using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIShop
{
    internal class Search
    {
        IWebDriver webDriver;
        [SetUp]
        public void StartChrome()
        {
            webDriver = new ChromeDriver(".");
            webDriver.Url = "http://shop.demoqa.com/";
            webDriver.FindElement(By.XPath("/html/body/p/a")).Click();
        }
        [Test, Category("Search")]
        public void SearchForExistingProducts()
        {
            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[2]/div/a")).Click();
            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[3]/div[2]/form/input[1]")).SendKeys("Jeans");
            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[3]/div[2]/form/input[1]")).SendKeys(Keys.Enter);

            IWebElement Jeans = webDriver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div/div/div[1]/div/h3/a"));
            Boolean jeansDisplayed = Jeans.Displayed;
            Assert.Pass();
        }
        [Test, Category("Search")]
        public void SearchForExistingProduct()
        {
            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[2]/div/a")).Click();
            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[3]/div[2]/form/input[1]")).SendKeys("Black Cross Back Maxi Dress");
            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[3]/div[2]/form/input[1]")).SendKeys(Keys.Enter);

            IWebElement blackDress = webDriver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/h1"));
            Boolean blackDressDisplayed = blackDress.Displayed;
            Assert.Pass();
        }
        [Test, Category("Search")]
        public void SearchForNotExistingProducts()
        {
            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[2]/div/a")).Click();
            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[3]/div[2]/form/input[1]")).SendKeys("Hot peppers");
            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[3]/div[2]/form/input[1]")).SendKeys(Keys.Enter);

            IWebElement errorMessage = webDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/p"));
            Boolean errorMessageTrue = errorMessage.Equals("Sorry, but nothing matched your search criteria. Please try again with some different keywords.");
            if(errorMessageTrue == true)
            {
                Assert.Pass();
            }
            else 
            { 
                Assert.Fail(); 
            }
            
        }
        [TearDown]
        public void Close()
        {
            webDriver.Close();
        }
    }
}
