using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundUpFundraiser.Helpers
{
    public class Base_Page<T>
    {
        protected IWebDriver driver;

        protected Base_Page(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement FindElementByCSS(By element)
        {
            return driver.FindElement(element);
        }

        public String GetTextFromInputField(By by)
        {
            return FindElementByCSS(by).Text;
        }

        public void VerifyTwoStrings(By by, string txt)
        {
            Assert.That(GetTextFromInputField(by), Is.EqualTo(txt));
        }
    }
}
