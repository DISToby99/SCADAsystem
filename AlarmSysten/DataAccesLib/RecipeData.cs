using DataAccesLib.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccesLib
{

    public static class RecipeRead
    {
        public static List<RecipeModels> Table;
        public static List<List<string>> TableList;
        public static List<bool> AlarmAck;
        public static List<RecipeList> RecipeTable;

     

    }
    public class RecipeList
    {
        public static List<string> row;
        public static bool AlarmAck;
    }

    public static class RecipeSearch
    {
        public static List<RecipeModels> Table;
        public static List<List<string>> TableList;
    }

    public class RecipeData : IRecipeData
    {



        private readonly ISQLDataAccess _db;
       
        public RecipeData(ISQLDataAccess db)
        {
            _db = db;
           

        }

        public Task<List<TagLog>> GetTags(string sql)
        {
            return _db.LoadData<TagLog, dynamic>(sql, new { });
        }
        public Task<List<RecipeModels>> GetRecipes(string sql)
        {
            return _db.LoadData<RecipeModels, dynamic>(sql, new { });
        }

        public Task<List<AlarmData>> GetAlarms(string sql)
        {
            return _db.LoadData<AlarmData, dynamic>(sql, new { });
        }

        public Task<List<AlarmConf>> GetAlarmConfigs(string sql)
        {
            return _db.LoadData<AlarmConf, dynamic>(sql, new { });
        }


        public Task<List<SqlData>> GetData(string sql)
        {
            return _db.LoadData<SqlData, dynamic>(sql, new { });
        }

        public Task InsertRecipe(RecipeModels recipe)
        {
            string sql = @"insert into recipe values (@batch, @id, @hcl)";
            return _db.SaveData(sql, recipe);

        }

        public Task EditRecipe(string sql)
        {
            return _db.SaveData(sql, new { });
        }


    }

}
