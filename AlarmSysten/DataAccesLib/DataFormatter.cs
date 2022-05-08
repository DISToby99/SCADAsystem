using DataAccesLib.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccesLib
{
    public class DataFormatter
    {
        public int nColumns;


        public List<List<string>> DataFormat(string TableType, List<RecipeModels> recipes)
        {
            List<List<string>> list = new List<List<string>>();
            if (TableType == "PIX318") { return Pix318Model(recipes); }
            else if (TableType == "PIX318Analyse") { return Pix318ModelAnalyse(recipes); }
            else return list;
        }


        public List<List<string>> Pix318Model(List<RecipeModels> recipes)
        {
            List<List<string>> FormattedList = new List<List<string>>();



            foreach (RecipeModels recipe in recipes)
            {
                List<string> TempList = new List<string>();

                TempList.Add(recipe.BatchNr.ToString());
                TempList.Add(recipe.Dato);
                TempList.Add(recipe.SAP.ToString());
                TempList.Add(recipe.ID);
                TempList.Add(recipe.Reaktor.ToString());
                TempList.Add(recipe.SatsVolum.ToString());
                TempList.Add(recipe.ForvFe.ToString());
                TempList.Add(recipe.OnsketFe.ToString());
                TempList.Add(recipe.OnsketSyre.ToString());
                TempList.Add(recipe.OnsketFe2.ToString());
                TempList.Add(recipe.HCLType.ToString());
                TempList.Add(recipe.ForvDamp.ToString());
                TempList.Add(recipe.VannOverordnet.ToString());
                TempList.Add(recipe.VarmtVann.ToString());
                TempList.Add(recipe.SpillVann.ToString());
                TempList.Add(recipe.ScrubberVaeske.ToString());
                TempList.Add(recipe.HCL.ToString());
                TempList.Add(recipe.Jernsulfat.ToString());
                TempList.Add(recipe.Temp.ToString());
                TempList.Add(recipe.Modningstid.ToString());
                TempList.Add(recipe.DampVentil.ToString());
                TempList.Add(recipe.Etterspyling.ToString());
                TempList.Add(recipe.O2Trykk.ToString());
                TempList.Add(recipe.O2Reaksjonstid.ToString());
                TempList.Add(recipe.DeltaTemp.ToString());
                //Are Present in Analysis
                //TempList.Add(recipe.AnalysertFe3.ToString());
                //TempList.Add(recipe.AnalysertFeTot.ToString());
                TempList.Add(recipe.VannSluttJustering.ToString());
                TempList.Add(recipe.VirkeligMVann.ToString());
                TempList.Add(recipe.TotTilLager.ToString());

                //Not part of columns, used in editing and filtering
                TempList.Add(recipe.filter.ToString());
                TempList.Add(recipe.edit.ToString());

                FormattedList.Add(TempList);
                nColumns = TempList.Count() - 2;

            }

            return FormattedList;
        }

        public List<List<string>> Pix318ModelAnalyse(List<RecipeModels> recipes)
        {
            List<List<string>> FormattedList = new List<List<string>>();

            foreach (RecipeModels recipe in recipes)
            {
                List<string> TempList = new List<string>();

                TempList.Add(recipe.BatchNr.ToString());
                TempList.Add(recipe.Dato);
                TempList.Add(recipe.ID);
                TempList.Add(recipe.TotalFe.ToString());
                TempList.Add(recipe.Egenvekt.ToString());
                TempList.Add(recipe.Verdi2Fe.ToString());
                TempList.Add(recipe.ManuellVerdi2Fe.ToString());
                TempList.Add(recipe.Verdi3EtterManuell2Fe.ToString());
                TempList.Add(recipe.Verdi3Fe.ToString());
                TempList.Add(recipe.FriSyre.ToString());

                //Not part of columns, used in editing and filtering
                TempList.Add(recipe.filter.ToString());
                TempList.Add(recipe.edit.ToString());

                FormattedList.Add(TempList);
                nColumns = TempList.Count() - 2;

            }

            return FormattedList;
        }

        public List<List<string>> Alarms(List<AlarmData> alarms)
        {
            List<List<string>> FormattedList = new List<List<string>>();

            foreach (AlarmData entry in alarms)
            {
                List<string> TempList = new List<string>();


                TempList.Add(entry.AlarmId.ToString());
                TempList.Add(entry.ActivationTimeStamp.ToString());
                if(entry.ActivationTimeStamp == entry.ActivationTimeStamp)
                {
                    TempList.Add("--");
                }
                else
                {
                    TempList.Add(entry.AcknowledgeTimeStamp.ToString());
                }
                


                TempList.Add(entry.AcknowledgeOperator.ToString());
                TempList.Add(entry.Silence.ToString());
                //TempList.Add(entry.SilenceDuration.ToString());
                TempList.Add(entry.SeverityName.ToString());
                TempList.Add(entry.Acknowledge.ToString());

                FormattedList.Add(TempList);
                nColumns = TempList.Count();

            }

            return FormattedList;
        }

        public List<List<string>> Tags(List<TagLog> Tags)
        {
            List<List<string>> FormattedList = new List<List<string>>();

            foreach (TagLog entry in Tags)
            {
                List<string> TempList = new List<string>();


                TempList.Add(entry.TimeStamp.ToString());
                TempList.Add(entry.TagId.ToString());
                TempList.Add(entry.Value.ToString());
                TempList.Add(entry.Quality.ToString());
                TempList.Add(entry.Status.ToString());

                FormattedList.Add(TempList);
                nColumns = TempList.Count();

            }

            return FormattedList;
        }

        public List<List<string>> AlarmConfig(List<AlarmConf> Tags)
        {
            List<List<string>> FormattedList = new List<List<string>>();

            foreach (AlarmConf entry in Tags)
            {
                List<string> TempList = new List<string>();


                TempList.Add(entry.AlarmId.ToString());

                TempList.Add(entry.TagId.ToString());
                TempList.Add(entry.AlarmType.ToString());
                TempList.Add(entry.AlarmDescription.ToString());
                TempList.Add(entry.SeverityName.ToString());
                TempList.Add(entry.Disable.ToString());



                FormattedList.Add(TempList);
                nColumns = TempList.Count();

            }

            return FormattedList;
        }


        public List<List<string>> DataFormat(List<SqlData> Table)
        {
            List<List<string>> FormattedList = new List<List<string>>();

            foreach (SqlData entry in Table)
            {
                List<string> TempList = new List<string>();


                TempList.Add(entry.Name1.ToString());
                TempList.Add(entry.Name2.ToString());
                TempList.Add(entry.Name3.ToString());
                TempList.Add(entry.Name4.ToString());
                TempList.Add(entry.Name5.ToString());
                TempList.Add(entry.Name6.ToString());
                TempList.Add(entry.Name7.ToString());
                TempList.Add(entry.Name8.ToString());
                TempList.Add(entry.Name9.ToString());
                TempList.Add(entry.Name10.ToString());


                FormattedList.Add(TempList);
                nColumns = TempList.Count() - 2;

            }

            return FormattedList;
        }
    }
}
