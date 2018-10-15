using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace CiaranSiteAutomation
{
    public class TestStorePage
    {
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void StoreThroughMenu()
        {
            NavigateTo.StoreThroughTheMenu();
            Thread.Sleep(500);
        }
        [Test]
        public void StoreThroughContents()
        {
            NavigateTo.StoreThroughContents();
            Thread.Sleep(500);
        }
        [Test]
        public void AutumnThroughStore()
        {
            NavigateTo.AutumnThroughStore();
            Thread.Sleep(500);
        }
        [Test]
        public void MasksThroughStore()
        {
            NavigateTo.MasksThroughStore();
            Thread.Sleep(500);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
