using FizzBuzz.DAL.Interfaces;
using FizzBuzz.Models;
using System.Data;
using System.Data.SqlClient;

namespace FizzBuzz.DAL
{
    public class FizzBuzzDataRepo : IFizzBuzzDataRepo
    {
        public void SaveFizzBuzzResults(List<FizzBuzzResult> results)
        {
            // Convert Results List to Data table.
            DataTable resultsTable = new DataTable();
            resultsTable.Columns.Add("ResultID", typeof(int));
            resultsTable.Columns.Add("ResultText",typeof(string));

            foreach (var result in results)
            {
                resultsTable.Rows.Add(result.FizzBuzzNumber, result.FizzBuzzResultText);
            }

            // Save result data table to DB using Stored Procedure.

            var connectionString = "Data Source=AMPRAJ-LAPTOP;Initial Catalog=FizzBuzz;Integrated Security=SSPI;";

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.InsertFizzBuzzResults", conn)) 
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = cmd.Parameters.AddWithValue("Results", resultsTable);
                    param.SqlDbType = SqlDbType.Structured;
                    param.TypeName = "dbo.FizzBuzzResultsType";

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
