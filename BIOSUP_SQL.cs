using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BiosupCS
{
    public class BIOSUP_SQL
    {
        SqlDataReader Bios_Data_Reader = null;
        private String str_connection_url;
        public List<String> list_results;

        public BIOSUP_SQL(String str_connection_url)
        {
            this.str_connection_url = str_connection_url;
        }
        public List<String> main()
        {
            using (SqlConnection connection = new SqlConnection(this.str_connection_url))
            {
                try
                {
                    String str_SQL = "SELECT * FROM dbo.chipset_check";
                    SqlCommand myCommand = new SqlCommand(str_SQL, connection);

                    myCommand.Connection.Open();

                    Bios_Data_Reader = myCommand.ExecuteReader();
                    while (Bios_Data_Reader.Read())
                    {
                        list_results.Add((Bios_Data_Reader.GetValue(0) + " - " + Bios_Data_Reader.GetValue(1) + " - " + Bios_Data_Reader.GetValue(2)));
                    }
                    Bios_Data_Reader.Close();
                    myCommand.Dispose();
                    connection.Close();
                    return (list_results);
                }
                // Handle any errors that may have occurred.
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}

