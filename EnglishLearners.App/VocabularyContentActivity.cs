
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace EnglishLearners.App
{
    [Activity(Label = "VocabularyContentActivity")]
    public class VocabularyContentActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            // Create your application here
            EditText title = FindViewById<EditText>(Resource.Id.title);
            EditText def = FindViewById<EditText>(Resource.Id.def);
            EditText type = FindViewById<EditText>(Resource.Id.type);
            this.FindViewById<Button>(Resource.Id.btn).Click += this.Click;
        }
        public void Click(object sender,EventArgs e)
        {
            Toast.MakeText(this,"Hello World",ToastLength.Short);
        }
    }
}
