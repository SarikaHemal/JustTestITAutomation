using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace JustTestITAutomation.Steps
{
    [Binding]
    public class HomePageSteps 
    {
        private IWebDriver driver;
        public HomePageSteps(IWebDriver driver)
        {
           this.driver = driver;
        }
    }
}
