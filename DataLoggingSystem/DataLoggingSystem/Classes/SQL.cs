using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace DataLoggingSystem
{
    class SQL
    {
        public static void SendToSQL(double data, int TagId)
        {
            float SQLdata = (float)data;
            string dataX = SQLdata.ToString("0.00");
            string connectionString = @"Server = VEAS-PC277\SQLEXPRESS; 
                                            Database = SCADA; 
                                            Integrated Security = True; Pooling = False";
            string sqlQuery = $"EXEC DataInsert @TagId = {TagId} , @Value = " + SQLdata.ToString().Replace(',', '.') + " ;";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            //try
            //{
                

                cmd.ExecuteNonQuery();

                
            //}
            //catch { MessageBox.Show("It could not write to SQL"); }

            con.Close();
        }


    }
}
