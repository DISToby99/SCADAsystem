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

namespace DataLoggingSystem
{
    public partial class DeleteAlarms : Form
    {
        string connectionString = @"Server = VEAS-PC277\SQLEXPRESS; 
                                            Database = SCADA; 
                                            Integrated Security = True; Pooling = False";

        public DeleteAlarms()
        {
            InitializeComponent();
            getAlarm();
        }

        private void getAlarm()
        {
            string sqlQuery = $"SELECT * FROM ALARM_CONFIGURATION;";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            List<string> TAGname = new List<string>();
            try
            {


                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Alarm.Items.Add(dr["AlarmDescription"].ToString());
                }


            }
            catch { MessageBox.Show("Could not find Alarm"); }

            con.Close();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            string sqlQuery = $"DELETE FROM ALARM_CONFIGURATION WHERE AlarmDescription = '{Alarm.Text}';";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            try
            {


                cmd.ExecuteNonQuery();


        }
            catch { MessageBox.Show("Could not delete Alarm"); }

    con.Close();
            this.Close();
        }
    }
}
