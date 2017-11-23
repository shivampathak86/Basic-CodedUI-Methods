using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITest;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Framework.Extentions;
using System.Diagnostics;

namespace Framework
{
    public class Base
    {

        public static Process process = null;
        public static BrowserWindow Intialize(Uri uri)
        {
           // Playback.Initialize();
            BrowserExtension.BrowserType(Browser.IE);
            Browserwindow = BrowserWindow.Launch(uri);
            process = Browserwindow.Process;
            Browserwindow.Maximized = true;
            Browserwindow.CloseOnPlaybackCleanup = false;

            return Browserwindow;

        }


        public static void CleanUp()
        {
            if (Playback.IsInitialized)
            {
                Browserwindow.Close();
                Playback.Cleanup();
            }
        }



        public static BrowserWindow Browserwindow
        {

            get
            {
                BrowserWindow _br = new BrowserWindow();
                _br.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Window", PropertyExpressionOperator.Contains);
                if (_br.Exists)
                    return _br;
                else
                {
                    return null;
                }
            }
            set
            {

            }
        }

        public static object Browerwindow { get; internal set; }
    }
}
    

    

