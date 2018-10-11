using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiaranSiteAutomation
{
    public class HomePage
    {
        public HomePage()
        {
              PageFactory.InitElements(Driver.driver, this);

        }

        [FindsBy(How = How.CssSelector, Using = "#comp-jg6qm35d > p:nth-child(1) > span > span")]
        public IWebElement Headline1 { get; set; }
    }
}
