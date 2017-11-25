using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Framework;
using BasicFunctions;
using System.Diagnostics;

namespace BasicFunctions
{
    /// <summary>
    /// This class will be basic operation handling using CodedUI
    /// </summary>
    [CodedUITest]
    public class ImportantMethods
    {
       
       
        [TestInitialize]
        public void TestInitialize ()
        {
            BrowserWindow.ClearCookies();
            Base.Browserwindow= Base.Intialize(new Uri("https://www.hdfcbank.com"));
        }
        [TestCleanup]
        public void TestCleanUp()
        {
            Base.CleanUp();
        }
        [TestCategory("Basic Functions")]
        [TestMethod]
        [Description("This test will navigate to Different URL from already opened browser Instance")]
        [Owner("Shivam Pathak")]
        public void HandlingNavigateToUrlMethod()
        {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;
            
            Base.Browserwindow.NavigateToUrl(new Uri("http://www.google.com"));
            
          
        }

        [TestCategory("Basic Functions")]
        [Description("This test will click on Image that comes on webpage like popup ")]
        [Owner("Shivam Pathak")]
        [TestMethod]
        public void ClickingonImagePopUp()

        {

           

            ImagPopup.ClickingOnImagePopup();//.NavigateToNewHandle().ComeBacktoDefaultHandle();

        }

        [TestCategory("Basic Functions")]
        [Description(" ")]
        [Owner("Shivam Pathak")]
        [TestMethod]
        public void HandlingMutipleTabs()
        {

            HandlingBrowserWindow.ClickingOnImagePopup().Click_on_loginButtn().Clicking_Control_On_NewTab();



        }

[TestMethod]
        public void Comparing_AreSame_and_IsEqual()
        {
            string a = "hello!";
            string b = a;

            string c = "Hello 2!";
            string d = "Hello 2!";

            Assert.AreSame(c, d, "The test will fail");

            Assert.AreEqual(b, a); // this test will fail

            Assert.AreEqual(d, c);// this test will pass

            
           
        }


        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        
    }
}
