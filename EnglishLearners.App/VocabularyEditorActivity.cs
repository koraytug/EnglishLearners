using System;
using System.IO;
using Android.App;
using Android.OS;
using Android.Widget;
using DataFlow;
namespace EnglishLearners.App
{
    [Activity(Label = "VocabularyEditorActivity")]
    public class VocabularyEditorActivity : Activity
    {
        EditText title,def,type;
        public static string VocabularyPosition;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.content_vocabulary_list);
            // Create your application here
             title = FindViewById<EditText>(Resource.Id.title);
             def = FindViewById<EditText>(Resource.Id.def);
             type = FindViewById<EditText>(Resource.Id.type);
            this.FindViewById<Button>(Resource.Id.btn).Click += this.Click;
        }
        public void Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            VocabularyModel mymodel = new VocabularyModel
            {
                Title = title.Text,
                Definition = def.Text,
                Type = type.Text,
                VocabularyId = Guid.NewGuid()
            };
            string db_name = "englishlearner_db.sqlite";
            string folderpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string db_path = Path.Combine(folderpath, db_name);
            DatabaseHelper dbhelper = new DatabaseHelper();
            if (!File.Exists(db_path))
            {
                //Database and table Create
                dbhelper.CreateTable(db_path);
                Toast.MakeText(ApplicationContext, "Database and Table Sucessfully Created", ToastLength.Short).Show();
            }
            bool result = dbhelper.Insert(db_path, mymodel);
            if(result)
            {
                Toast.MakeText(ApplicationContext, "Record Added", ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(ApplicationContext, "Woow! Something Went Wrong", ToastLength.Short).Show();

            }
        }
       
    }
}