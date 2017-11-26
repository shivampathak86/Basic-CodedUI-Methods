using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.IO;
using ExcelDataReader;

namespace Framework.HelperFiles
{
    public class ExcelDataReader
    {
        public static TestContext testcontext;
        public void ReaderFromExcel()
        {
            var cmd = testcontext.DataConnection.CreateCommand();
            cmd.CommandText = "Select * from [Sheet1$]";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var UserName = reader.GetValue(0).ToString();
                var PWD = reader.GetValue(1).ToString();


            }

        }


        public DataTable ExcelReader()
        {

            using (FileStream sw = File.Open("", FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(sw))
                {
                    var ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    }
                    );

                    DataTableCollection tables = ds.Tables;
                    DataTable dt = tables["Sheet1"];
                    return dt;

                }
            }
            
        }
        List<Datacollectiontable> dt = new List<Datacollectiontable>();
        public void ExcelWritter()
        {
            

            DataTable table = ExcelReader();
            for (int row =1;row <table.Rows.Count;row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    Datacollectiontable dtcol = new Datacollectiontable()
                    {
                        row = row,
                        col = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };

                    dt.Add(dtcol);
                }

            }



        }

        public string DataValue(int rownumbr, string colnam)
        {
            string data = (from value in dt
                           where value.row == rownumbr && value.col == colnam
                           select value.colValue).SingleOrDefault();

            return data.ToString();

        }

    }
                
  


    public class Datacollectiontable
    {
        public int row { get; set; }
        public string col { get; set; }
        public string colValue { get; set; }
    }


           
}


    

