using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using static System.Collections.Specialized.BitVector32;

namespace UIShop
{
    public class Tests
    {
        IWebDriver webDriver;

        [SetUp]
        public void StartChrome()
        {
            webDriver = new ChromeDriver(".");
            webDriver.Url = "http://shop.demoqa.com/";
            webDriver.FindElement(By.XPath("/html/body/p/a")).Click();
        }

        [Test, Category("Access the system")]
        public void AccessTheSystemWithNotLoggedUser()
        {



            // web element Displayed
            IWebElement navigationBar = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]"));
            Boolean navibationBar_enabled = navigationBar.Enabled;
            IWebElement header = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[2]/div/div/div"));
            Boolean header_enabled = header.Enabled;

            Assert.Pass();
        }
        [Test, Category("Access the system")]
        public void AccessTheSystemWithLoggedinUser()
        {

            IWebElement navigationBar = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]"));
            Boolean navibationBar_enabled = navigationBar.Enabled;
            IWebElement header = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[2]/div/div/div"));
            Boolean header_enabled = header.Enabled;
            Assert.Pass();
        }
        
        [TearDown]
          public void Close()
            {
                webDriver.Close();
            }

    }
    
}