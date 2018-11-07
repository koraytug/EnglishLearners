
using EnglishLearners.App.Models;
using System.Data.SqlClient;
namespace EnglishLearners.App
{
    public class DatabaseHelper
    {
        internal bool Insert(VocabularyModel data, string db_path)
        {
            using (var con = new SqlConnection (db_path))
            {
                using ( var cmd = new SqlCommand("insert into VocabularyRepository (Title,Def,Type) values (@Title,@Def,@Type)",con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@Title", data.Title);
                    cmd.Parameters.AddWithValue("@Def", data.Definition);
                    cmd.Parameters.AddWithValue("@Type", data.Type);
                    int count = cmd.ExecuteNonQuery();
                    con.Close();
                    return count > 0 ? true : false;
                }
            }
        }
        internal bool CreateTable(string db_path)
        {

            using (var con = new SqlConnection(db_path))
            {
                con.Open();
                string createquery = "@CREATE TABLE IF NOT EXISTS [VocabularyRepository] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,[Title] NVARCHAR(200) NULL,[Def] NVARCHAR(200) NULL,[Type] NVARCHAR(200) NULL)";
                using (SqlCommand cmd = new SqlCommand(createquery, con))
                {
                    cmd.CommandText = createquery;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }

            return true;
        }
    }
}
