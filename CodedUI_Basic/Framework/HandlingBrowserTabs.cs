using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class HandlingBrowserTabs
    {


        public HandlingBrowserTabs Click_On_NewTab()
        {
            Base.Browserwindow = BrowserWindow.Locate("Google");

            WinTabList tablist = new WinTabList(Base.Browserwindow);
            WinButton newtabbutton = new WinButton(tablist);
            newtabbutton.SearchProperties.Add(WinButton.PropertyNames.Name, "New tab (Ctrl+T)");
            newtabbutton.WaitForControlEnabled();
            Mouse.Click(newtabbutton);

            return new HandlingBrowserTabs();
        }

        public  HandlingBrowserTabs Navigating_new_Site_in_newtab ()
        {
            var br = BrowserWindow.Locate("New tab");

             
            br.NavigateToUrl(new Uri("http://www.youtube.com"));

            br.WaitForControlReady();

            return  new HandlingBrowserTabs();
        }

    }
}
