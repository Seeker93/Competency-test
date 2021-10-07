using Microsoft.VisualBasic.FileIO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public class Question10
{
    public DataTable WriteToTable(String pathToCsv)
    {

        DataTable dataTable = new DataTable();
        using (StreamReader reader = new StreamReader(pathToCsv))
        {
            string[] headers = reader.ReadLine().Split(',');
            foreach (string header in headers)
            {
                dataTable.Columns.Add(header);
            }
            while (!reader.EndOfStream)
            {
                string[] rows = reader.ReadLine().Split(',');

                DataRow dataRow = dataTable.NewRow();

                if (rows[0] == null || rows[1] == null || rows[2] == null)
                { // Check if non-nullable fields are null
                    System.Console.WriteLine("CSV data is not in the correct format");
                    break;
                }

                if (rows[0].Length > 255 || rows[1].Length > 255 || rows[2].Length > 255 || rows[3].Length > 255)
                { // These rows cannot be over 255 characters in length
                    System.Console.WriteLine("CSV data is not in the correct format");
                    break;
                }

                if (rows[3].Length > 12) // Phone number cannot be longer than 12 characters
                {
                    System.Console.WriteLine("CSV data is not in the correct format");
                    break;
                }

                for (int i = 0; i < headers.Length - 1; i++)
                {
                    dataRow[i + 1] = rows[i];
                }

                dataTable.Rows.Add(dataRow);
            }
        }

        return dataTable;
    }

    public void InsertDataIntoSQLServerUsingSQLBulkCopy(DataTable csvFileData)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString =
          "Data Source=SRVWINSQL001;" +
          "Initial Catalog=ThirdParty;" +
          "User id=RandomUser;" +
          "Password=randompassword123;";
        conn.Open();
        {
            using (SqlBulkCopy s = new SqlBulkCopy(conn))
            {
                s.DestinationTableName = "dbo.Users";
                s.WriteToServer(csvFileData);
            }
        }
    }
}
