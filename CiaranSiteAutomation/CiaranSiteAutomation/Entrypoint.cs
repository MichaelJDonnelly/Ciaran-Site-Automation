using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiaranSiteAutomation
{
    public class Entrypoint
    {
        static void Main()
        {
            Menu menu = new Menu();

            Driver.driver.Navigate().GoToUrl("https://ciarandonnellymusi.wixsite.com/hnc-website/home-1");
            menu.Home.Click();
        }
    }
}
