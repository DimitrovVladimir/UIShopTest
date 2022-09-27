using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
           
            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[1]/a"));
            IWebElement myWishlist = webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[1]/a"));
           
            Assert.Pass();
        }
        [Test, Category("Access the system")]
        public void AccessTheSystemWithLoggedinUser()
        {

            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[1]/a"));
            Assert.Pass();
        }
        [Test, Category("Add product to Cart")]
        public void VerifyAddingTheProductToCart()
        {
            //LoginUser
            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[2]/a")).Click();
            webDriver.FindElement(By.Id("username")).SendKeys("pnrkouwsohyhlgaavs@bvhrk.com");
            webDriver.FindElement(By.Id("password")).SendKeys("Pineapple250590");
            webDriver.FindElement(By.Name("login")).Click();
            webDriver.FindElement(By.XPath("/html/body/div[1]/header/div[2]/div/div/div/div/a/img")).Click();


            IWebElement singleProduct = webDriver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[3]/div/div[2]/div/div/div/div[2]/div[2]/div[1]/div/h3/a"));
            singleProduct.Click();
            IWebElement colorDropDown = webDriver.FindElement(By.Name("attribute_pa_color"));
            IWebElement sizeDropDown = webDriver.FindElement(By.Name("attribute_pa_size"));
            SelectElement color = new SelectElement(colorDropDown);
            color.SelectByValue("pink");
            SelectElement size = new SelectElement(sizeDropDown);
            size.SelectByValue("36");
            webDriver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/form/div/div[2]/button")).Click();
            //fall or assert



            Assert.Pass();
        }
        [Test, Category("Navigation bar")]
        public void VerifyUserManagementSectionWithNotLoggedUser()
        {

            webDriver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/ul[2]/li[2]/a")).Click();
            IWebElement registerForm = webDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/main/article/div/div/div[2]/div[2]"));
            //fall or assert
            Assert.Pass();
        }
        [TearDown]
        public void Close() 
        {
            webDriver.Close();
        }
    }
}