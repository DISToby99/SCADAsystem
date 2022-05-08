using DataAccesLib.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLib
{
    public class DataWrite
    {
        string header = "";
        List<String> data = new List<string>();
        filtering[] filter;

        public DataWrite(filtering[] _filter)
        {
            
            filter = _filter;

            dataformat();
        }
        
        void dataformat()
        {
          foreach(var Var  in filter)
            {
                if (!Var.sort)
                {
                    header = header + Var.variable + ",";
                }
            }

            data.Add(header);

          for(int i = 0; i < RecipeRead.Table.Count; i++)
            {
                string line = "";
                if (!filter[0].sort)
                {
                    line = line + RecipeRead.Table[i].BatchNr.ToString() + ",";
                    
                }
                if (!filter[1].sort)
                {
                    line = line + RecipeRead.Table[i].Dato + ",";
                    Debug.WriteLine(line);
                }
                if (!filter[2].sort)
                {
                    line = line + RecipeRead.Table[i].SAP.ToString() + ",";
                }
                if (!filter[3].sort)
                {
                    line = line + RecipeRead.Table[i].ID.ToString() + ",";
                }
                if (!filter[4].sort)
                {
                    line = line + RecipeRead.Table[i].Reaktor.ToString() + ",";
                }
                if (!filter[5].sort)
                {
                    line = line + RecipeRead.Table[i].SatsVolum.ToString() + ",";
                }
                if (!filter[6].sort)
                {
                    line = line + RecipeRead.Table[i].ForvFe.ToString() + ",";
                }
                if (!filter[7].sort)
                {
                    line = line + RecipeRead.Table[i].OnsketFe.ToString() + ",";
                }
                if (!filter[8].sort)
                {
                    line = line + RecipeRead.Table[i].OnsketSyre.ToString() + ",";
                }
                if (!filter[9].sort)
                {
                    line = line + RecipeRead.Table[i].OnsketFe2.ToString() + ",";
                }
                if (!filter[10].sort)
                {
                    line = line + RecipeRead.Table[i].HCLType.ToString() + ",";
                }
                if (!filter[11].sort)
                {
                    line = line + RecipeRead.Table[i].ForvDamp.ToString() + ",";
                }
                if (!filter[12].sort)
                {
                    line = line + RecipeRead.Table[i].VannOverordnet.ToString() + ",";
                }
                if (!filter[13].sort)
                {
                    line = line + RecipeRead.Table[i].VarmtVann.ToString() + ",";
                }
                if (!filter[14].sort)
                {
                    line = line + RecipeRead.Table[i].SpillVann.ToString() + ",";
                }
                if (!filter[15].sort)
                {
                    line = line + RecipeRead.Table[i].ScrubberVaeske.ToString() + ",";
                }
                if (!filter[16].sort)
                {
                    line = line + RecipeRead.Table[i].HCL.ToString() + ",";
                }
                if (!filter[17].sort)
                {
                    line = line + RecipeRead.Table[i].Jernsulfat.ToString() + ",";
                }
                if (!filter[18].sort)
                {
                    line = line + RecipeRead.Table[i].Temp.ToString() + ",";
                }
                if (!filter[19].sort)
                {
                    line = line + RecipeRead.Table[i].Modningstid.ToString() + ",";
                }
                if (!filter[20].sort)
                {
                    line = line + RecipeRead.Table[i].DampVentil.ToString() + ",";
                }
                if (!filter[21].sort)
                {
                    line = line + RecipeRead.Table[i].Etterspyling.ToString() + ",";
                }
                if (!filter[22].sort)
                {
                    line = line + RecipeRead.Table[i].O2Trykk.ToString() + ",";
                }
                if (!filter[23].sort)
                {
                    line = line + RecipeRead.Table[i].O2Reaksjonstid.ToString() + ",";
                }
                if (!filter[24].sort)
                {
                    line = line + RecipeRead.Table[i].DeltaTemp.ToString() + ",";
                }
                if (!filter[25].sort)
                {
                    line = line + RecipeRead.Table[i].AnalysertFe3.ToString() + ",";
                }
                if (!filter[26].sort)
                {
                    line = line + RecipeRead.Table[i].AnalysertFeTot.ToString() + ",";
                }
                if (!filter[27].sort)
                {
                    line = line + RecipeRead.Table[i].VannSluttJustering.ToString() + ",";
                }
                if (!filter[28].sort)
                {
                    line = line + RecipeRead.Table[i].VirkeligMVann.ToString() + ",";
                }
                if (!filter[29].sort)
                {
                    line = line + RecipeRead.Table[i].TotTilLager.ToString();
                }
                
                data.Add(line.Trim());
             
            }
        }

        public void dataWriteToCSV()
        {
            string name = @"\Resept_PIX318.csv";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            
            File.Delete(path + name);

            foreach (var line in data)
            {
               
                File.AppendAllText(path + name, line  + Environment.NewLine);
            }
            
        }

    }
}
