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

namespace EnglishLearners.App.Models
{
    public class VocabularyModel
    {
        public int VocabularyId
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Definition
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }
    }
}