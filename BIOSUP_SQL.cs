using System;
using System.Data.SqlClient;

namespace BiosupCS
{
    public class BIOSUP_SQL
    {

        public static void main(String str_connection_url)
        {
            using (SqlConnection connection = new SqlConnection(
               str_connection_url))
            {
                try
                {
                    String str_SQL = "SELECT * FROM dbo.chipset_check";
                    SqlCommand myCommand = new SqlCommand(str_SQL, connection);
                    myCommand.Connection.Open();
                    myCommand.ExecuteNonQuery();


                }
                // Handle any errors that may have occurred.
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}

