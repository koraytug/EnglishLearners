using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using DataFlow;
using EnglishLearners.App.Adapters;
using EnglishLearners.App.Repositories;

namespace EnglishLearners.App
{
    [Activity(Label = "VocabularyActivity", Theme = "@style/AppTheme", MainLauncher = true)]
    public class VocabularyActivity : Activity
    {
       // private ArrayAdapter<VocabularyModel> mAdapterVocabulary;
        private VocabularyRecyclerAdapter mVocabularyRecyclerAdapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.vocabulary_list);
            initializeDisplayContent();
        }
        protected override void OnResume()
        {
            base.OnResume();
            mVocabularyRecyclerAdapter.NotifyDataSetChanged();
        }
        public void initializeDisplayContent()
        {
            string db_name = "englishlearner_db.sqlite";
            string folderpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string db_path = Path.Combine(folderpath, db_name);
            DatabaseHelper helper = new DatabaseHelper();
            RecyclerView recyclerVocabulary = FindViewById<RecyclerView>(Resource.Id.list_vocabulary);
            LinearLayoutManager listLayoutManager = new LinearLayoutManager(this);
            recyclerVocabulary.SetLayoutManager(listLayoutManager);
            VocabularyRepository vocabularyRepository = new VocabularyRepository();
            List<VocabularyModel> vocabularies = helper.GetData(db_path);
            VocabularyRecyclerAdapter vocabularyRecyclerAdapter = new VocabularyRecyclerAdapter(vocabularies, this);
            mVocabularyRecyclerAdapter = vocabularyRecyclerAdapter;
            recyclerVocabulary.SetAdapter(mVocabularyRecyclerAdapter);
        }
    }
}