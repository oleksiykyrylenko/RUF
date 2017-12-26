using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundUpFundraiser
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected string URL;

        [SetUp]  
        public void SetUP()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        public void GoToPage(string URL)
        {

            this.URL = URL;
            if (!driver.Url.Equals(URL))
            {
                driver.Navigate().GoToUrl(URL);
            }
        }
    }
}
