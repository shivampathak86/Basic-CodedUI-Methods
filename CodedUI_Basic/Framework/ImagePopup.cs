using System;
using Framework;
using Microsoft.VisualStudio.TestTools.UITest;
using Microsoft.VisualStudio.TestTools.UITesting;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace BasicFunctions
{
    public class ImagPopup
    {
        public static ImagPopup ClickingOnImagePopup()
        {
            Mouse.Hover(ImagePopup);
            Mouse.Click(CancelButtonOnImage);
            return new ImagPopup();
        }
        public static HtmlDocument document
        {
            get
            { bool Page_loaded = Base.Browserwindow.WaitForControlExist();
                HtmlDocument doc = new HtmlDocument(Base.Browserwindow);
                if (Page_loaded == true)
                {
                    
                    doc.SearchProperties.Add(HtmlDocument.PropertyNames.ControlType, "Document");
                    if(doc.Exists)
                    {
                        return doc;
                    }
                }
                return null; 
                
            }
        }
         public static HtmlImage ImagePopup
        {
            get
            {
                HtmlImage image = new HtmlImage(document);
                image.SearchProperties.Add(HtmlImage.PropertyNames.ControlType, "Image");
                image.FilterProperties.Add(HtmlImage.PropertyNames.TagInstance, "42");
                if (image.Exists)
                {
                    return image;
                }
                else { 
                return null;
                }
            }
        }
        //Base.Browserwindow.SearchProperties.Add(UITestControl.PropertyNames.ClassName, "IEFrame");

        public static HtmlImage CancelButtonOnImage
        {
            get
            {
                HtmlImage Cxlimage = new HtmlImage(document);
                Cxlimage.SearchProperties.Add(HtmlImage.PropertyNames.ControlType, "Image");
                Cxlimage.FilterProperties.Add(HtmlImage.PropertyNames.TagInstance, "41");
                if (Cxlimage.Exists)
                {
                    return Cxlimage;
                }
                else
                {
                    return null;
                }
            }
        }


    }

    
        }
