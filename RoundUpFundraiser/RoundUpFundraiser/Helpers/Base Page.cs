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


        public String GetAttributeValue(IWebElement element, string attribute)
        {
            return element.GetAttribute(attribute);
            
        }
        
        public void VerifyAttributeValue(IWebElement element, string attribute, string expectedResult)
        {
            Assert.That(GetAttributeValue(element, attribute), Is.EqualTo(expectedResult));
        }

    }
}
