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
        public  HtmlHyperlink ContinueButton_Control_On_newTab
          {
            get
            {
                //WinWindow newTab = new WinWindow();
                //newTab.SearchProperties.Add(WinWindow.PropertyNames.Name, "NetBanking");
                //newTab.WindowTitles.Add("NetBanking");
                //newTab.SetFocus();


                //if (newTab.Exists)
                //{
                
                BrowserWindow newTab = new BrowserWindow();
                newTab.SearchProperties.Add(BrowserWindow.PropertyNames.Name, "NetBanking", PropertyExpressionOperator.Contains);
                newTab.SearchProperties.Add(BrowserWindow.PropertyNames.ClassName, "IFrame", PropertyExpressionOperator.Contains);
                newTab.WindowTitles.Add("NetBanking");

                Mouse.Hover(newTab);
                HtmlDocument doc = new HtmlDocument(newTab);
                doc.SearchProperties.Add(HtmlDocument.PropertyNames.Title, "NetBanking");
                doc.FilterProperties.Add( HtmlDocument.PropertyNames.TagInstance, "-1");
                
                    
                    HtmlHyperlink HtmlhyperLink_Btn = new HtmlHyperlink(doc);
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
            Mouse.Hover(ContinueButton_Control_On_newTab);
            Mouse.Click(ContinueButton_Control_On_newTab);

            return new HandlingBrowserWindow();
        }
    





    }





    }

