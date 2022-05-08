using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLib
{

    
    public class TableFilter
    {
        public List<Models.RecipeModels> FilteredTable = new List<Models.RecipeModels>();

 

        public void BatchSort(int batch)
        {
            foreach (var recipe in RecipeRead.Table)
            {
                if (recipe.BatchNr == batch)
                {
                    FilteredTable.Add(recipe);
                }
            }

            RecipeRead.Table = FilteredTable;
        }
    }
}
