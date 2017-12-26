using OpenQA.Selenium;
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
        
        }

        private By eEmailAddress = By.CssSelector("#UserEmail");
        private By eConfirmEmailAddress = By.CssSelector("#UserEmailConfirm");
        private By ePassword = By.CssSelector("#UserPassword");

        public void VerifyTextInInputFields()
        {
            VerifyTwoStrings(eEmailAddress, "Please enter an email address");
            VerifyTwoStrings(eConfirmEmailAddress, "Please confirm the email address");
            VerifyTwoStrings(ePassword, "#UserPassword");
        }
    }
}
