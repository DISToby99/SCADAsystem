using System.Diagnostics;

namespace DataAccesLib.Models
{
    public class QueriesV1
    {
        public static int TableLen = 10;
        public static string sql = $"SELECT top ({ TableLen }) * FROM PIX318_ReseptData ORDER BY BatchNr DESC";
        public string _tableName;


        public void SetTableType(string TableName)
        {
            _tableName = TableName;
        }

        public string TableUpdate()
        {
            string sql = "";

            if (_tableName == "Alarms")
            {
                //sql = $"SELECT top({ TableLen }) * FROM ALARM_DATA ORDER BY ActivationTimeStamp DESC";
                sql = $"SELECT TOP 20 * FROM ALARM_DATA WHERE Acknowledge = 0 ORDER BY ActivationTimeStamp DESC";
            }
            else if (_tableName == "Tags")
            {
                sql = $"SELECT TOP 20 * FROM TAG_DATA ORDER BY TimeStamp DESC";
            }
            else if (_tableName == "AlarmConfig")
            {
                sql = $"SELECT * FROM ALARM_CONFIGURATION ORDER BY AlarmId DESC";
            }


            return sql;

        }

        public string AlarmAck(string AlarmId, string timestamp)
        {
            string sql = $"UPDATE ALARM_DATA SET Acknowledge = 1 WHERE AlarmId = {AlarmId} AND ActivationTimeStamp between '{timestamp}.000' AND '{timestamp}.999'";
            Debug.WriteLine(sql);
       
            return sql;
        }

        public string AlarmAckQuery()
        {

            string sql = $"SELECT TOP 20 * FROM ALARM_DATA WHERE Acknowledge = 1 ORDER BY ActivationTimeStamp DESC";
            return sql;
        }
    }
}
