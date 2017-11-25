using BasicFunctions;
using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UITest.Extension;

namespace Framework
{
    public class HandlingBrowserWindow : ImagPopup
    { 
        public static  new HandlingBrowserWindow ClickingOnImagePopup()
        {
            Mouse.Hover(ImagePopup);
            Mouse.Click(CancelButtonOnImage);
            return new HandlingBrowserWindow();
        }



        public  HtmlHyperlink LoginBtn
        {
            get
            {
                HtmlHyperlink loginButton = new HtmlHyperlink(document);
                loginButton.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id, "loginsubmit", PropertyExpressionOperator.EqualTo);
                if (loginButton.TryFind())
                {
                    return loginButton;
                }
                else
                {
                    return null;
                }

            }
        }

        public  HandlingBrowserWindow Click_on_loginButtn()
        {
            Mouse.Click(LoginBtn);

            return new HandlingBrowserWindow();
        }

        public  WinTabPage ContinueToLogin_WindowTab
        {

            get
            {
                WinTabList ListOfTabs = new WinTabList(Base.Browserwindow);
                WinTabPage newtab = new WinTabPage(ListOfTabs);

                if (newtab.TryFind())
                {
                    return newtab;
                }
                else
                {
                    return null;
                }
            }
        }

        public HtmlDocument Doc_On_NewPopup
        {

            get
            {

                //BrowserWindow _br = BrowserWindow.Locate("NetBanking");
                BrowserWindow br = new BrowserWindow();
                br.SearchProperties.Add(UITestControl.PropertyNames.Name, "NetBanking");
                br.SearchProperties.Add(UITestControl.PropertyNames.ClassName, "IEFrame");
                br.WindowTitles.Add("NetBanking");



                HtmlDocument doc = new HtmlDocument(br);
                doc.SearchProperties.Add(HtmlDocument.PropertyNames.ControlType, "NetBanking");
                doc.FilterProperties.Add(HtmlDocument.PropertyNames.TagInstance, "-1");
                doc.WindowTitles.Add("NetBanking");

                return doc;
            }
        }
        public HtmlImage Image_On_PopUp
          {
            get
            { 
                //WinWindow newTab = new WinWindow();
                //newTab.SearchProperties.Add(WinWindow.PropertyNames.Name, "NetBanking");
                //newTab.WindowTitles.Add("NetBanking");
                //newTab.SetFocus();


                //if (newTab.Exists)
                //{

                

                HtmlImage img_On_New_Window = new HtmlImage(Doc_On_NewPopup);
                img_On_New_Window.SearchProperties[HtmlImage.PropertyNames.ControlType] = "Image";
                img_On_New_Window.FilterProperties[HtmlImage.PropertyNames.TagInstance] = "3";
                img_On_New_Window.FilterProperties[HtmlImage.PropertyNames.AbsolutePath] = "/assets/popuppages/images/banner_4_desktop.jpg";
                 
                if(img_On_New_Window.TryFind())
                {
                    return img_On_New_Window;
                }
                else
                {
                    return null;
                }
            }
          }

        public HtmlHyperlink ClickToContinue_Button_On_Popup
        {
            get
            {
                HtmlHyperlink HtmlhyperLink_Btn = new HtmlHyperlink(Doc_On_NewPopup);
                HtmlhyperLink_Btn.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, "Continue to NetBanking",
                    PropertyExpressionOperator.Contains);
                if (HtmlhyperLink_Btn.Exists)
                {
                    return HtmlhyperLink_Btn;
                }
                else
                {
                    return null;
                }
            }
        }
        
              
               
            
          


      public  HandlingBrowserWindow Clicking_Control_On_NewTab()
        {
            Mouse.Hover(Image_On_PopUp);
            
            Mouse.Hover(ClickToContinue_Button_On_Popup);
            Mouse.Click(ClickToContinue_Button_On_Popup);
            

            return new HandlingBrowserWindow();
        }
    





    }





    }

