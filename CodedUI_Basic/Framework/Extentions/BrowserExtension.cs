using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Extentions
{
   public  class BrowserExtension
    {
       public static void BrowserType( Browser browser)
        {
            if(browser==Browser.Chrome)
            {   

                BrowserWindow.CurrentBrowser = "chrome";

            }

            else if(browser==Browser.Firefox)
            {
                BrowserWindow.CurrentBrowser = "firefox";

            }
            else if(browser==Browser.IE)
            {
                BrowserWindow.CurrentBrowser = "IE"; 
            }
            else
            {
                BrowserWindow.CurrentBrowser = "IE";
            }
        }

    }


    public enum Browser
    {
        IE,
        Firefox,
        Chrome

    }
}
