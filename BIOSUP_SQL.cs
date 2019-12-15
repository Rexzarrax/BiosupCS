using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BiosupCS
{
    public class BIOSUP_SQL
    {
        public SqlDataReader Bios_Data_Reader = null;
        public SqlConnection connection;
        private string str_connection_string;

        public BIOSUP_SQL(String str_connection_url)
        {
            this.str_connection_string = str_connection_url;
        }

        public DataTable BIOSUP_SQL_GET(String str_SQL)
        {
            DataTable my_table = new DataTable();
            using (connection = new SqlConnection(this.str_connection_string))
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
                    
                    return my_table;
                }
                // Handle any errors that may have occurred.
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw e;
                }
            }
        }
        public void BIOSUP_SQL_SET(String str_SQL)
        {
            using (connection = new SqlConnection(this.str_connection_string))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(str_SQL, connection);
                    Console.WriteLine(str_SQL);
                    cmd.CommandType = CommandType.Text;
                    //SqlDataAdapter my_adapter = new SqlDataAdapter(cmd);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw e;
                }

            }

        }
        /*public void BIOSUP_SQL_SET(String str_procedurename, List<SQL_Params> list_parameter)
        {
            using (connection = new SqlConnection(this.str_connection_string))
            using (var command = new SqlCommand(str_procedurename, connection)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                try
                {   
                    foreach(SQL_Params param in list_parameter)
                    {
                        command.Parameters.Add(param.str_parameter, param.DBT_Type, param.int_size ).Value = param.any_value;
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }

            }

        }*/

    }
    public class SQL_Params
    {
        public String str_parameter;
        public SqlDbType DBT_Type;
        public int int_size;
        public dynamic any_value;

        public SQL_Params(String str_parameter, SqlDbType DBT_Type, int int_size, dynamic any_value)
        {
            this.str_parameter = str_parameter;
            this.DBT_Type = DBT_Type;
            this.int_size = int_size;
            this.any_value = any_value;
        }
    }
}