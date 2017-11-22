using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITest;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Framework.Extentions;

namespace Framework
{
    public class Base
    { public static BrowserWindow Browserwindow;
        
        public static void Intialize ()
        {
            Playback.Initialize();
            BrowserExtension.BrowserType(Browser.Chrome);
            Browserwindow = BrowserWindow.Launch(new Uri("http://www.google.com"));

            Browserwindow.Maximized = true;
            Browserwindow.CloseOnPlaybackCleanup=false;

        }


        public static void CleanUp()
        {
            if(Playback.IsInitialized)
            {
                Browserwindow.Close();
                Playback.Cleanup();
            }
        }

       
        

    }
}
