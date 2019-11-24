using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BiosupCS
{
    public class BIOSUP_SQL
    {
        SqlDataReader Bios_Data_Reader = null;
        private String str_connection_url;
        public DataTable my_table = new DataTable();

        public BIOSUP_SQL(String str_SQL,String str_connection_url)
        {
            this.str_connection_url = str_connection_url;
            using (SqlConnection connection = new SqlConnection(this.str_connection_url))
            {
                try
                {
                    SqlCommand myCommand = new SqlCommand(str_SQL, connection);
                    Console.WriteLine(str_SQL);

                    SqlDataAdapter my_adapter = new SqlDataAdapter(myCommand);

                    my_adapter.Fill(my_table);
                    connection.Open();

                    Bios_Data_Reader = myCommand.ExecuteReader();
                    Bios_Data_Reader.Read();

                    Bios_Data_Reader.Close();
                    myCommand.Dispose();
                    connection.Close();
                }
                // Handle any errors that may have occurred.
                catch (Exception e)
                 {
                    Console.WriteLine(e);
                }
            }
        }
    }
}

