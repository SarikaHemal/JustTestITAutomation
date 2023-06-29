
using JustTestITAutomation.CommonMethod;
using OpenQA.Selenium;

namespace JustTestITAutomation.Pages
{
    public class RegisterPage
    {
        private IWebDriver driver;
        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement LoginTextBox => driver.WaitForElement(By.Id("username"));
        private IWebElement FirstNameTextBox => driver.WaitForElement(By.Id("firstName"));
        private IWebElement LastNameTextBox => driver.WaitForElement(By.Id("lastName"));
        private IWebElement PasswordTextBox => driver.WaitForElement(By.Id("password"));
        private IWebElement ConfirmPasswordTextbox => driver.WaitForElement(By.Id("confirmPassword"));
        private IWebElement RegisterButton => driver.WaitForElement(By.XPath("//button[contains(.,'Register')]"));
        private IWebElement CancelButton => driver.WaitForElement(By.XPath("//a[contains(.,'Cancel')]"));
        private IWebElement SuccessMessage => driver.WaitForElement(By.XPath("//div[contains(text(),'Registration is successful')]"));

        private IWebElement UserExitsMessage => driver.WaitForElement(By.XPath("//div[contains(text(),'User already exists')]"));
        private IWebElement InvalidPasswordMessage=> driver.WaitForElement(By.XPath("//div[contains(text(),'InvalidPasswordException')]"));

        public void ClickRegisterButton()
        {
            RegisterButton.Submit();
        }
        public void EnterRegisterData(string email, string firstName, string lastName, string password, string confirmPassword)
        {
            LoginTextBox.SendKeys(email);
            FirstNameTextBox.SendKeys(firstName);
            LastNameTextBox.SendKeys(lastName);
            PasswordTextBox.SendKeys(password);
            ConfirmPasswordTextbox.SendKeys(confirmPassword);
            ClickRegisterButton();
            
            
        }
        public string ValidAlertMessage()
        {
            try { 
            if (SuccessMessage.Displayed)
                     return SuccessMessage.Text;
             }
            catch { }
            try
            {
                if (UserExitsMessage.Displayed)
                    return UserExitsMessage.Text;
            }
            catch { }
            try
            {
                if (InvalidPasswordMessage.Displayed)
                    return InvalidPasswordMessage.Text;
            }
            catch { }

            return "Not valid alert message";
            
        }
        public HomePage ClickCancelButton()
        {
            CancelButton.Click();
            return new HomePage(driver);
        }

        

    }
}


