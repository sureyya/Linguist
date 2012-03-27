using System;
using Linguist.Model;

namespace Linguist.Repository.Repositories
{
    public interface ITranslationRepository
    {
        Translation GetFirstTranslation(Guid wordGuid);
    }
}
