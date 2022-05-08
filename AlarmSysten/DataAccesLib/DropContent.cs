using DataAccesLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLib

{
    
    public static class DropContent
    {
        public static string btnBatch = "Batch";
        public static string btnDato = "Dato";
        public static string btnID = "ID";

        public static List<int> batch = new List<int>();
        public static List<String> dato = new List<string>();
        public static List<string> ID = new List<string>();

       
        


        public static List<int> BatchDrop()
        {
            batch.Clear();
        
                for (int i = 0; i < RecipeRead.Table.Count; i++)
                {
                    batch.Add(RecipeRead.Table[i].BatchNr);
                }
     
            return batch;
        }

        public static List<String> DatoDrop()
        {
            dato.Clear();
            for (int i = 0; i<RecipeRead.Table.Count; i++)
            {

                if (!dato.Contains(RecipeRead.Table[i].Dato))
                    dato.Add(RecipeRead.Table[i].Dato);
            }
            return dato;
        }


        public static List<string> IdDrop()
        {
            ID.Clear();
            for(int i = 0; i < RecipeRead.Table.Count; i++)
            {
                if (!ID.Contains(RecipeRead.Table[i].ID))
                    ID.Add(RecipeRead.Table[i].ID);
            }
            return ID;
        }

        public static void btnBatchLabel(int selected)
        {
            btnBatch = selected.ToString();
            List<RecipeModels> FilterMem = new List<RecipeModels>();

            foreach (var recipe in RecipeRead.Table)
            {
                if (recipe.BatchNr == selected)
                {
                    FilterMem.Add(recipe);
                }

            }
        
            Queries.TableLen = FilterMem.Count();
            RecipeRead.Table = FilterMem;

        }

        public static void btnDatoLabel(string selected)
        {
            btnDato = selected;
        }

        public static void btnIDLabel(string selected)
        {
            btnID = selected.ToString();
            List<RecipeModels> FilterMem = new List<RecipeModels>();

            foreach (var recipe in RecipeRead.Table)
            {
                if(recipe.ID == selected)
                {
                    FilterMem.Add(recipe);
                }
            }

            Queries.TableLen = FilterMem.Count();
            RecipeRead.Table = FilterMem;
        }
    }
}
