using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundUpFundraiser.Test_Scripts
{
   [TestFixture]
    public class New_Account_TC : BaseTest
    {
        private string CreateAccountURL = "https://roundupfundraiser-staging.azurewebsites.net/User/UserNew";
        public New_Account_TC()
        {
                    
        }

        [Test]
        /*
         * When 'Create New Account' page loads, it displays

    'I'm not a robot' checkbox, unchecked
    'Enter email address' and 'Confirm email address' and 'Enter password' fields contain stated placeholder text
       */

        public void Verify_Create_Account_Page()
        {
            GoToPage(CreateAccountURL);
        }
    }
}
