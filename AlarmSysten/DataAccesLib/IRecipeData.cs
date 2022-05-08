using DataAccesLib.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccesLib
{
    public interface IRecipeData
    {
        Task<List<RecipeModels>> GetRecipes(string sql);
        Task<List<AlarmData>> GetAlarms(string sql);
        Task<List<TagLog>> GetTags(string sql);
        Task<List<SqlData>> GetData(string sql);
        Task<List<AlarmConf>> GetAlarmConfigs(string sql);

        Task InsertRecipe(RecipeModels recipe);

        Task EditRecipe(string sql);
    }
}