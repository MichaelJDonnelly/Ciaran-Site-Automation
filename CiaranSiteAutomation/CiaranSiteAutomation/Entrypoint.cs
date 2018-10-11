using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CiaranSiteAutomation
{
    public class Entrypoint
    {
        static void Main()
        {
            Driver.driver.Navigate().GoToUrl("https://ciarandonnellymusi.wixsite.com/hnc-website/home-1");

            NavigateTo.StoreThroughTheMenu();

            Thread.Sleep(500);

            Driver.driver.Navigate().GoToUrl("https://ciarandonnellymusi.wixsite.com/hnc-website/home-1");

            NavigateTo.StoreThroughContents();

            Thread.Sleep(500);

            Driver.driver.Quit();
        }
    }
}
