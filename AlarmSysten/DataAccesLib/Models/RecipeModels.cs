using System.Collections.Generic;

namespace DataAccesLib.Models
{
    public class RecipeModels
    {
        public int BatchNr { get; set; }

        public string Dato { get; set; }
        public int SAP { get; set; }
        public string ID { get; set; }
        public int Reaktor { get; set; }

        public double SatsVolum { get; set; }
        
        public double ForvFe { get; set; }
        public double OnsketFe { get; set; }
        public double OnsketSyre { get; set; }
        public double OnsketFe2 { get; set; }
        public double HCLType { get; set; }
        public double ForvDamp { get; set; }
        public double VannOverordnet { get; set; }
        public double VarmtVann { get; set; }
        public double SpillVann { get; set; }
        public double ScrubberVaeske { get; set; }
        public double HCL { get; set; }
        public double Jernsulfat { get; set; }
        public double Temp { get; set; }
        public double Modningstid { get; set; }
        public double DampVentil { get; set; }
        public bool Etterspyling { get; set; }
        public double O2Trykk { get; set; }
        public double O2Reaksjonstid { get; set; }
        public double DeltaTemp { get; set; }
        public double AnalysertFe3 { get; set; }
        public double AnalysertFeTot { get; set; }
        public double VannSluttJustering { get; set; }
        public double VirkeligMVann { get; set; }
        public double TotTilLager { get; set; }

        //Analysis
        public double TotalFe { get; set; }
        public double Egenvekt { get; set; }
        public double Verdi2Fe { get; set; }
        public double ManuellVerdi2Fe { get; set; }
        public double Verdi3EtterManuell2Fe { get; set; }
        public double Verdi3Fe { get; set; }
        public double FriSyre { get; set; }



        public bool filter { get; set; }
        public bool edit { get; set; }


    }

    public class SqlData
    {
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }
        public string Name5 { get; set; }
        public string Name6 { get; set; }
        public string Name7 { get; set; }
        public string Name8 { get; set; }
        public string Name9 { get; set; }
        public string Name10 { get; set; }
    }

    public class AlarmConfig
    {
        public string AlarmId { get; set; }
        public string SeverityName { get; set; }
        public string Tag { get; set; }
        public string AlarmType { get; set; }
        public string AlarmDescription { get; set; }
        public bool Disable { get; set; }

     

    }

    public class AlarmConf
    {
        public string AlarmId { get; set; }
        
        public string TagId { get; set; }
        public string AlarmType { get; set; }
        
        public string AlarmDescription { get; set; }
        public string SeverityName { get; set; }
        public bool Disable { get; set; }
    }

    public class AlarmType
    {
        public string Alarm { get; set; }

    }
    
    public class SeverityConfiguration
    {
        public string SeverityName { get; set; }
        public int SeverityLevel { get; set; }

    }

    public class TagLog
    {
        public string TimeStamp { get; set; }
        public string TagId { get; set; }
        public string Value { get; set; }
        public string Quality { get; set; }
        public string Status { get; set; }  
    }


    public class AlarmData
    {
        public string AlarmId { get; set; }
        public string ActivationTimeStamp { get; set; }
        public string AcknowledgeTimeStamp { get; set; }
        public string AcknowledgeOperator { get; set; }
        public string Silence { get; set; }
        public string SilenceDuration { get; set; }
        public string SeverityName { get; set; }
        public bool Acknowledge { get; set; }
    }

    public class TagData
    {
        public string TimeStamp { get; set; }
        public string TagId { get; set; }
        public string Value { get; set; }
        public string Quality { get; set; }
        public string Status { get; set; }

    }

    public class TagConfig
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public string ItemId { get; set; }
        public string Desc { get; set; }
    }

    

    public static class Extensions
    {
        public static string[] AlarmConfigExtensions = new string[]
        {
            "AlarnId",
            "Severityame",
            "TagId",
            "AlarmType",
            "AlarmDescription",
            "Disable", 
            "Value"
        };

        public static string[] AlarmDataExtensions = new string[]
        {
            "AlarmId",
            "ActivationTimeStamp",
            "Ack TimeStamp",
            "Ack Operator",
            "Silence",
            //"Silence Duration",
            "Severity Name",
            "Acknowledge"


        };

        public static string[] TagDataExtensions = new string[]
        {
            "TimeStamp",
            "TagId",
            "Value",
            "Quality",
            "Status"
        };
        

    }
    
  
    //public static class FilterModel
    //{
    //    //make this a list
    //    public static bool[] filter { get; set; } = new bool[26];
    //    public static string[] StringFilter = new string[]
    //    {

    //    "BatchNr",

    //     "Dato",
    //     "SAP",
    //     "ID",
    //     "Reaktor",
    //     "Satsvolum",
    //     "ForvFe",
    //     "OnsketFe",
    //     "OnsketSyre",
    //     "OnsketFe2",
    //     "HCLType",
    //     "ForvDamp",
    //     "VannOverordnet",
    //     "VarmtVann",
    //     "SpillVann",
    //     "ScrubberVaeske",
    //     "HCL",
    //     "Jernsulfat",
    //     "Temp",
    //     "Modningstid",
    //     "Dampventil",
    //     "Etterspyling",
    //     "O2Trykk",
    //     "O2Reaksjonstid",
    //    "DeltaTemp",
    //    //"AnalysertFe3",
    //    //"AnalysertFeTot",

    //    "VannSluttjustering",
    //    "VirkeligMVann",
    //    "TotTilLager",
    //    "TotalFe",
    //    "Egenvekt",
    //    "Verdi2Fe",
    //    "ManuellVerdi2Fe",
    //    "Verdi3EtterManuell2Fe",
    //    "Verdi3Fe",
    //    "FriSyre",


    //};


    //}

    public class filtering
    {
        public bool sort { get; set; }
        public string variable { get; set; }
    }

    public class EditRow
    {
        public List<EditInstance> Edits { get; set; }
        
    }

    public class EditInstance
    {
        public string Name { get; set; }
        public bool filter { get; set; }
    }

   public static class TableColumnLength
    {

    }
}
