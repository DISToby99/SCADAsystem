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
    public partial class AlarmSetup : Form
    {
        string connectionString = @"Server = VEAS-PC277\SQLEXPRESS; 
                                            Database = SCADA; 
                                            Integrated Security = True; Pooling = False";
        string TAGname;

        public AlarmSetup()
        {
            InitializeComponent();
            getAlarm();
            getSeverity();
            getTag();

        }

        private void getTag()
        {
            string sqlQuery = $"SELECT * FROM TAG_CONFIGURATION;";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            List<string> TAGname = new List<string>();
            try
            {


                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TAGname.Add(dr["TagName"].ToString());
                    TAG.Items.Add(TAGname.Last());
                }


            }
            catch { MessageBox.Show("Could not find sensors"); }

            con.Close();
        }

        private void getSeverity()
        {
            string sqlQuery = $"SELECT * FROM SEVERITY_CONFIGURATION;";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            List<string> TAGname = new List<string>();
            try
            {


                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DDSeverity.Items.Add(dr["SeverityName"].ToString());
                }


            }
            catch { MessageBox.Show("Could not find sensors"); }

            con.Close();
        }

        private void getAlarm()
        {
            string sqlQuery = $"SELECT * FROM ALARM_TYPE;";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            List<string> TAGname = new List<string>();
            try
            {


                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DDAlarmType.Items.Add(dr["AlarmType"].ToString());
                }


            }
            catch { MessageBox.Show("Could not find sensors"); }

            con.Close();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            string Severity = DDSeverity.Text;
            string AlarmType = DDAlarmType.Text;
            string level = txtLvl.Text;
            string DS = txtDescription.Text;
            getTagId();

            if (string.IsNullOrEmpty(TAGname)) MessageBox.Show("TAG name can not be null");
            else if (string.IsNullOrEmpty(Severity)) MessageBox.Show("Severity can not be null");
            else if (string.IsNullOrEmpty(AlarmType)) MessageBox.Show("Alarm type can not be null");
            else if (string.IsNullOrEmpty(level)) MessageBox.Show("level can not be null");
            else
            {
                
                int TAGid = Convert.ToInt32(TAGname);

                //int alarmtypeid = Convert.ToInt32(AlarmType);

                float alarmlevel = Convert.ToSingle(level);

                string sqlQuery = "INSERT INTO ALARM_CONFIGURATION(TagId, AlarmType, AlarmDescription, SeverityName, Value)" +
                                    $"VALUES({TAGid}, '{AlarmType}', '{DS}', '{Severity}', {alarmlevel}); ";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                //try
                //{


                   cmd.ExecuteNonQuery();


                //}
                //catch { MessageBox.Show("Could not create Alarm"); }

                con.Close();
                this.Close();
            }
        }

        private void getTagId()
        {
            string sqlQuery = $"SELECT * FROM TAG_CONFIGURATION WHERE TagName IN('{TAG.Text}');";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            try
            {


                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TAGname = dr["TagId"].ToString();
                }


            }
            catch { MessageBox.Show("Could not find sensor with"); }

            con.Close();


        }
    }
}
