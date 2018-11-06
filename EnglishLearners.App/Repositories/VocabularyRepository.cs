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
using EnglishLearners.App.Models;

namespace EnglishLearners.App.Repositories
{
    class VocabularyRepository
    {

        public List<VocabularyModel> getVocabularies()
        {
            List<VocabularyModel> vacabularies = new List<VocabularyModel>()
            {
                new VocabularyModel()
                {
                    VocabularyId = 1,
                    Title= "Their",
                    Definition = "onların / their friends : onların arkadaşları",
                    Type = "adverb"
                },
                new VocabularyModel()
                {
                    VocabularyId = 2,
                    Title= "Then ",
                    Definition = "o zaman / ondan sonra / öyleyse / Then I went to work : Ondan sonra işe gittim",
                    Type = "adverb"
                },
                new VocabularyModel()
                {
                     VocabularyId =3,
                    Title= "There",
                    Definition = "Orada / oraya / I will go there : Oraya gideceğim",
                    Type = "Vocabulary"
                },
                new VocabularyModel()
                {
                     VocabularyId = 4,
                    Title= "This",
                    Definition = "bu / this book : bu kitap",
                    Type = "Vocabulary"
                },
                new VocabularyModel()
                {
                     VocabularyId = 5,
                    Title= "Two",
                    Definition = " iki / two girls : iki kız",
                    Type = "Vocabulary"
                },
                new VocabularyModel()
                {
                    VocabularyId = 6,
                    Title= "Up",
                    Definition = "yukarı / stand up : Ayağa (yukarı) kalk",
                    Type = "adverb"
                },
                new VocabularyModel()
                {
                     VocabularyId =7,
                    Title= "Want",
                    Definition = "istemek / I want Money : Para isterim (istiyorum)",
                    Type = "adverb"
                },
                new VocabularyModel()
                {
                     VocabularyId = 8,
                    Title= "Well",
                    Definition = "iyi (zarf) / He speaks well : O iyi (şekilde) konuşur",
                    Type = "adverb"
                },
                new VocabularyModel()
                {
                    VocabularyId = 9  ,
                    Title= "Went",
                    Definition = "onların / their friends : onların arkadaşları",
                    Type = "adverb"
                }
            };
            return vacabularies;
        }
    }
}