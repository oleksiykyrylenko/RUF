using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RoundUpFundraiser.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundUpFundraiser.POMs
{
    public class Create_New_Account_Page : Base_Page<Create_New_Account_Page>
    {
        public Create_New_Account_Page(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#UserEmail")]
        private IWebElement eEmailAddress { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#UserEmailConfirm")]
        private IWebElement eConfirmEmailAddress { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#UserPassword")]
        private IWebElement ePassword { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[@id='recaptcha-anchor']")]
        private IWebElement eCaptcha { get; set; }
     

        public void VerifyTextInInputFields()
        {
            VerifyAttributeValue(eEmailAddress, "data-val-required", "Please enter an email address");
            VerifyAttributeValue(eConfirmEmailAddress, "data-val-required", "Please confirm the email address");
            VerifyAttributeValue(ePassword, "data-val-required", "Please enter a password");
            //VerifyAttributeValue(eCaptcha, "aria-checked", "false");
        }
    }
}
