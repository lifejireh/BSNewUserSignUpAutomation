using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;


namespace BSTestFramework
{
    public class NewUserInfoPage
    {
       static IWebDriver driver = new ChromeDriver(@"C:\Users\apunoose\Documents\Visual Studio 2017");
        private By fullNameField = By.Id("fos_user_registration_form_name");
        private By phoneNumberField = By.Id("fos_user_registration_form_phone");
        private By emailAddressField = By.Id("fos_user_registration_form_email");
        private By passwdField = By.Id("fos_user_registration_form_plainPassword_first");
        private By repeatPwdField = By.Id("fos_user_registration_form_plainPassword_second");
        private By submitButton = By.Id("submitButton");

        
        public void NewUserSignUpInfo()
        {

            driver.Url = "https://www.bitesquad.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            var signUp = driver.FindElement(By.LinkText("Sign Up"));
            signUp.Click();
            Thread.Sleep(3000);

            Random rand = new Random();
            int rnd = rand.Next();

            var fullName = driver.FindElement(fullNameField);
            fullName.SendKeys("newuser" + rnd);

            var phoneNumber = driver.FindElement(phoneNumberField);
            phoneNumber.SendKeys("(101)-101-1010");

            var emailField = driver.FindElement(emailAddressField);
            emailField.SendKeys("newuser" + rnd + "@gmail.com");

            var pwdField = driver.FindElement(passwdField);
            pwdField.SendKeys("newuser1pwd");

            var rptpwdField = driver.FindElement(repeatPwdField);
            rptpwdField.SendKeys("newuser1pwd");

            var submitBtn = driver.FindElement(submitButton);
            submitBtn.Click();

            
        }

        public static bool Success()
        {
            return driver.PageSource.Contains("Your Bite Squad account is now activated");
            
        }

        public static void CloseBrowser()
        {
            driver.Close();
        }
    }
}
