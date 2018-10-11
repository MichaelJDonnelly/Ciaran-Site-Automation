﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiaranSiteAutomation
{
    public class ContentsPage
    {
        public ContentsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#comp-jg819a7e > h1 > span > a")]
        public IWebElement Home { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#comp-jg81bbim > h1 > span > a")]
        public IWebElement Store { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#comp-jg0051uy2bg")]
        public IWebElement Music { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#comp-jg0051uy3bg")]
        public IWebElement About { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#comp-jg0051uy4bg")]
        public IWebElement Contents { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#comp-jg0051uy5bg")]
        public IWebElement Other { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#comp-jg0051uy6bg")]
        public IWebElement Email { get; set; }
    }
}
