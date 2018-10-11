using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CiaranSiteAutomation
{
    class NavigateTo
    {
        public static void StoreThroughTheMenu()
        {
            Menu menu = new Menu();
            menu.Store.Click();
            Thread.Sleep(500);
        }

    public static void StoreThroughContents()
        {
            ContentsPage contentsPage = new ContentsPage();
            Menu menu = new Menu();
            menu.Contents.Click();
            Thread.Sleep(5000);
            contentsPage.Store.Click();
            Thread.Sleep(5000);
        }

    }
}
