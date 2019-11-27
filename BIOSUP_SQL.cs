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

        public virtual void SQL(String str_connection_url)
        {
            this.str_connection_url = str_connection_url;
            using (SqlConnection connection = new SqlConnection(this.str_connection_url))
            {

            }
        }
    }
    class BIOSUP_SQL_GET_DATA : BIOSUP_SQL
    {
        public override void SQL()
        {
            try
            {
                SqlCommand cmd = new SqlCommand(str_SQL, connection);
                Console.WriteLine(str_SQL);
                SqlDataAdapter my_adapter = new SqlDataAdapter(cmd);
                my_adapter.Fill(my_table);
                connection.Open();

                Bios_Data_Reader = cmd.ExecuteReader();
                Bios_Data_Reader.Read();

                Bios_Data_Reader.Close();
                cmd.Dispose();
                connection.Close();
            }
            // Handle any errors that may have occurred.
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
    class BIOSUP_SQL_SET_DATA : BIOSUP_SQL
    {
        public override void SQL()
        {
            string stmt = "INSERT INTO dbo.Test(id, name) VALUES(@ID, @Name)";

            SqlCommand cmd = new SqlCommand(smt, _connection);
            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters.Add("@Name", SqlDbType.VarChar, 100);

            for (int i = 0; i < 10000; i++)
            {
                cmd.Parameters["@ID"].Value = i;
                cmd.Parameters["@Name"].Value = i.ToString();

                cmd.ExecuteNonQuery();
            }
        }

    }
}

