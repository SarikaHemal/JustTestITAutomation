
using JustTestITAutomation.CommonMethod;
using OpenQA.Selenium;


namespace JustTestITAutomation.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement UserName => driver.WaitForElement(By.XPath("//span[contains(.,'Hi, Sarika')]"));
        private IWebElement RegisterLink => driver.WaitForElement(By.XPath("//a[contains(.,'Register')]"));
        private IWebElement LogOutLink => driver.WaitForElement(By.XPath("//a[@class='nav-link'][contains(.,'Logout')]"));
        private IWebElement PopuralMakeLink => driver.WaitForElement(By.XPath("//h2[@class='card-header text-xs-center'][contains(.,'Popular Make')]"));
        private IWebElement InvalidLoginMessage => driver.WaitForElement(By.XPath("//span[contains(.,'Invalid username/password')]"));

        public Boolean IsLogin(string userName)
        {
            return driver.WaitForElement(By.XPath("//span[contains(.,'" + userName + "')]")).Displayed;
        }
        public RegisterPage ClickOnRegisterLink()
        {
            RegisterLink.Click();
            return new RegisterPage(driver);
        }
        
        public Boolean ValidPopuralMakeLink()
        {
            return PopuralMakeLink.Displayed;

        }
        public string GetInValidUserandPasswordMessege()
        {
            return InvalidLoginMessage.Text;
        }
    }
}


