﻿using System;
using System.Linq;
using Linguist.Model;
using Linguist.Model.NullModels;
using Linguist.Repository.Core;

namespace Linguist.Repository.Repositories
{
    class TranslationRepository : RepositoryBase<LinguistContext> , ITranslationRepository
    {
        public Translation GetFirstTranslation(Guid wordGuid)
        {
            var dbWord = DataContext.Words.Include("Translations").FirstOrDefault(w => w.Id == wordGuid);

            if (dbWord != null && dbWord.Translations.Any())
            {
                return dbWord.Translations[0];
            }
            
            return new NullTranslation(dbWord.Text);
        }

        public void SaveTranslation(Translation translation)
        {
            DataContext.Words.First().Translations.Add(translation);

            DataContext.SaveChanges();
        }
    }
}
