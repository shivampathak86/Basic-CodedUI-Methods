using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Framework.HelperFiles
{
   public class ExcelReader
    {
        public static TestContext testcontext;
        public void  ReaderFromExcel()
        {
            var cmd = testcontext.DataConnection.CreateCommand();
            cmd.CommandText = "Select * from [Sheet1$]";
            var reader = cmd.ExecuteReader();
             while(reader.Read())
            {
                var UserName = reader.GetValue(0).ToString();
                var PWD = reader.GetValue(1).ToString();

                
            }
     
         
           

           
        }

    }
}
