using System;
using System.Collections.Generic;
using SQLite;
using System.Linq;
namespace DataFlow
{
    public class DatabaseHelper
    {
        public bool CreateTable(string db_path)
        {
            using (var con = new SQLite.SQLiteConnection(db_path))
            {
                con.CreateTable<VocabularyModel>();
                    return true;
            }
        }
        public bool Insert(string db_path,VocabularyModel data)
        {
            using (var con = new SQLite.SQLiteConnection(db_path))
            {
               int result =  con.Insert(data);
                return result > 0 ? true : false;
            }
        }
        public List<VocabularyModel> GetData(string db_path)
        {
            using (var con = new SQLite.SQLiteConnection(db_path))
            {
                return (from data in con.Table<VocabularyModel>() select data).ToList();
            }
        }
    }
}
