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
using System.Diagnostics;

namespace BasicFunctions
{
    /// <summary>
    /// This class will be basic operation handling using CodedUI
    /// </summary>
    [CodedUITest]
    public class ImportantMethods
    {
        public ImportantMethods()
        {
        }
        [ClassInitialize]
        public static void ClassIntialize(TestContext testContext)
        {
           //Base.Browserwindow= Base.Intialize();
        }
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


        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

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
