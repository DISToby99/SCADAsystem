using NationalInstruments;
using NationalInstruments.NetworkVariable;
using NationalInstruments.NetworkVariable.WindowsForms;
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
    public partial class Form1 : Form
    {
        double logginSampling = 2;
        bool IsSeconds = false;
        OPC opc;
        double fromOPC;
        double LastSQL = 0;
        double prst = 0.2;
        double fromOPCpower = 0;
        double LastSQLpower = 1;


        public Form1()
        {
            InitializeComponent();
            txtLogging.Text = logginSampling.ToString("0.00");
            txtUnit.Text = "%";
            sampling.Start();
            List<string> yValues = new List<string>();

        }

        private void sampling_Tick(object sender, EventArgs e)
        {
            sampling.Stop();
            GetFromOPC();
            if (!IsSeconds) LoggToSQLprs();
            sampling.Start();
        }

        private void GetFromOPC()
        {
            opc = new OPC();
            opc.ConnectOPC();

            fromOPC = opc.GetDataTemp();
            fromOPCpower = opc.GetDataPower();

            txtOPC.Text = fromOPC.ToString("0.00");
            txtOPCpower.Text = fromOPCpower.ToString("0.00");
        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {
            if (txtUnit.Text == "%")
            {
                IsSeconds = false;
                prst = Convert.ToDouble(txtLogging.Text) / 100;
            }
            else if (txtUnit.Text == "s")
            {
                IsSeconds = true;
                //LoggToSQL.Interval = Convert.ToInt32(txtLogging.Text);
            }
            else if (txtUnit.Text == "") IsSeconds = false;
            else MessageBox.Show("There is no configuration that allows" + txtUnit.Text);
        }

        private void txtLogging_TextChanged(object sender, EventArgs e)
        {
            if (IsSeconds)
            {
                if (txtLogging.Text != "") LoggToSQL.Interval = Convert.ToInt32(txtLogging.Text) * 1000;
                LoggToSQL.Start();
            }

            else if (txtLogging.Text != "")prst = Convert.ToDouble(txtLogging.Text)/100;
        }

        private void LoggToSQL_Tick(object sender, EventArgs e)
        {
            LoggToSQL.Stop();
            LastSQL = fromOPC;
            LastSQLpower = fromOPCpower;
            txtLast.Text = LastSQL.ToString("0.00");
            txtSQLpower.Text = LastSQLpower.ToString("0.00");
            SQL.SendToSQL(LastSQL, 1);
            SQL.SendToSQL(LastSQLpower, 2);
            LoggToSQL.Start();

        }

        private void LoggToSQLprs()
        {
            double diff = fromOPC - LastSQL;
            double check =  Math.Abs(diff)/ LastSQL;
            //txtLast.Text = prst.ToString("0.00");

            if (check > prst)
            {
                LastSQL = fromOPC;
                txtLast.Text = LastSQL.ToString("0.00");
                SQL.SendToSQL(LastSQL, 1);
            }

            diff = fromOPCpower - LastSQLpower;
            check = Math.Abs(diff) / LastSQLpower;

            if (check > prst)
            {
                LastSQLpower = fromOPCpower;
                txtSQLpower.Text = LastSQLpower.ToString("0.00");
                SQL.SendToSQL(LastSQLpower, 2);
            }
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            AlarmSetup Alarm = new AlarmSetup();
            Alarm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteAlarms Alarm = new DeleteAlarms();
            Alarm.ShowDialog();
        }
    }

}
