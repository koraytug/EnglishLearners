using System;
using System.Collections.Generic;
using DataFlow;
namespace EnglishLearners.App.Repositories
{
    class VocabularyRepository
    {
        List<VocabularyModel> vacabularies = new List<VocabularyModel>();
        public List<VocabularyModel> getVocabularies()
        {
            {
                vacabularies.Add(
                  new VocabularyModel()
                  {
                      VocabularyId = Guid.NewGuid(),
                      Title = "Their",
                      Definition = "onların / their friends : onların arkadaşları",
                      Type = "adverb"
                  }
                );
                vacabularies.Add(
                   new VocabularyModel()
                   {
                       VocabularyId = Guid.NewGuid(),
                       Title = "Then ",
                       Definition = "o zaman / ondan sonra / öyleyse / Then I went to work : Ondan sonra işe gittim",
                       Type = "adverb"
                   }
                 );
                vacabularies.Add(
               new VocabularyModel()
               {
                   VocabularyId = Guid.NewGuid(),
                   Title = "There",
                   Definition = "Orada / oraya / I will go there : Oraya gideceğim",
                   Type = "Vocabulary"
               }
             );
                vacabularies.Add(
           new VocabularyModel()
           {
               VocabularyId = Guid.NewGuid(),
               Title = "This",
               Definition = "bu / this book : bu kitap",
               Type = "Vocabulary"
           }
         );
                             vacabularies.Add(
           new VocabularyModel()
           {
               VocabularyId = Guid.NewGuid(),
               Title = "Two",
               Definition = " iki / two girls : iki kız",
               Type = "Vocabulary"
           }
         );
                                      vacabularies.Add(
           new VocabularyModel()
           {
               VocabularyId = Guid.NewGuid(),
               Title = "Up",
               Definition = "yukarı / stand up : Ayağa (yukarı) kalk",
               Type = "adverb"
           }
         );
                                             vacabularies.Add(
           new VocabularyModel()
           {
               VocabularyId = Guid.NewGuid(),
               Title = "Want",
               Definition = "istemek / I want Money : Para isterim (istiyorum)",
               Type = "adverb"
           }
         );
                                                    vacabularies.Add(
           new VocabularyModel()
           {
               VocabularyId = Guid.NewGuid(),
               Title = "Well",
               Definition = "iyi (zarf) / He speaks well : O iyi (şekilde) konuşur",
               Type = "adverb"
           }
         );
            };
            return vacabularies;
        }
    }
}