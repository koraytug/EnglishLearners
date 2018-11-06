using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using EnglishLearners.App.Adapters;
using EnglishLearners.App.Models;
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
            RecyclerView recyclerVocabulary = FindViewById<RecyclerView>(Resource.Id.list_vocabulary);
            LinearLayoutManager listLayoutManager = new LinearLayoutManager(this);
            recyclerVocabulary.SetLayoutManager(listLayoutManager);
            VocabularyRepository vocabularyRepository = new VocabularyRepository();
            List<VocabularyModel> vocabularies = vocabularyRepository.getVocabularies();
            VocabularyRecyclerAdapter vocabularyRecyclerAdapter = new VocabularyRecyclerAdapter(vocabularies, this);
            mVocabularyRecyclerAdapter = vocabularyRecyclerAdapter;
            recyclerVocabulary.SetAdapter(mVocabularyRecyclerAdapter);
        }
    }
}