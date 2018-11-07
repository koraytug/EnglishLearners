using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using DataFlow;
using Android.Views;
using EnglishLearners.App.Adapters;
using EnglishLearners.App.Repositories;
using System.Collections.Generic;

namespace EnglishLearners.App
{
    [Activity(Label = "Vocabulary List", Theme = "@style/AppTheme", MainLauncher = true)]
    public class VocabularyActivity : AppCompatActivity//Activity
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

            var toolbar = FindViewById<Toolbar>(Resource.Id.vacabulary_list_toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Your Vocabularies";
        }

        #region Menu işlemleri
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_vacabulary, menu);
            return base.OnCreateOptionsMenu(menu);
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {


            int id = item.ItemId;
            //string strMessage = "";

            //switch (id)
            //{
            //    case Resource.Id.btn_kaydet:
            //        strMessage = strMessage + " Kaydet";
            //        break;
            //    case Resource.Id.btn_sil:
            //        strMessage = strMessage + "Action selected:  Sil";
            //        break;
            //    case Resource.Id.btn_iptal:
            //        strMessage = strMessage + "Action selected:  İptal";
            //        break;
            //    default:
            //        break;
            //}

            if (!item.HasSubMenu)
                Android.Widget.Toast.MakeText(this, "Action selected: " + item.TitleFormatted,
                    Android.Widget.ToastLength.Short).Show();
            return base.OnOptionsItemSelected(item);
        }
        #endregion
    }
}