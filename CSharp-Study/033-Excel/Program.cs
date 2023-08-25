using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_Excel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Contact.xlsx";
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"+
                      "Data Source=" + fileName + ";"+ ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"";

            //1. Build the connection to the data source 
            OleDbConnection connection = new OleDbConnection(connectionString);

            //2. Open the file
            connection.Open();

            //3. Search
            string sql = "select * from [Sheet1$]"; //select all from sheet1 in xlsx
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql,connection);

            //4. Fill the query result (datatable) into the dataset
            DataSet dataSet = new DataSet(); //a data container to store data (data table)
            adapter.Fill(dataSet);

            //5. Close the connection
            connection.Close();

            //6. Get the data

            //6-0 Get the sheet
            DataTableCollection tableCollection = dataSet.Tables;
            DataTable table = tableCollection[0];//only 1 sheet was put, so index 0 is the sheet we search then got

            //6-1. Get the data in the sheet
            DataRowCollection rowCollection = table.Rows; //Get the rows in the table
            foreach (DataRow row in rowCollection)
            {
                for (int i = 0; i < 5; i++)//5 column
                {
                    Console.Write(row[i] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
