using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BiosupCS
{
    public class BIOSUP_SQL
    {
        MySqlConnection SQLConn;
        //public SqlDataReader Bios_Data_Reader = null;
        //public SqlConnection connection;

        public BIOSUP_SQL(String str_connection)
        {
            SQLConn = new MySqlConnection(str_connection);
            try
            {
                SQLConn.Open();
                Console.WriteLine(SQLConn.ServerVersion.ToString());
            }
            catch
            {
                throw new Exception("Database Connection Error");
            }
        }

        public DataTable BIOSUP_SQL_GET(String str_SQL)
        {
            try
            {
                ReopenConnections();
                Console.WriteLine(str_SQL);

                MySqlCommand cmd = new MySqlCommand(str_SQL, SQLConn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            // Handle any errors that may have occurred.
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

       public void BIOSUP_SQL_SET(String str_SQL)
            {
                Console.WriteLine(str_SQL);
                ReopenConnections();
                MySqlCommand cmd = new MySqlCommand(str_SQL, SQLConn);
                cmd.ExecuteNonQuery();
                SQLConn.Close();
            }
        public void ReopenConnections()
        {
            try
            {
                SQLConn.Close();
                SQLConn.Open();
            }
            catch
            {
                throw new Exception("Database Connection Error");
            }
        }
    }
}