using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linguist.Model.NullModels
{
    public class NullTranslation : Translation
    {
        public NullTranslation():this(string.Empty)
        {
            
        }

        public NullTranslation(string word)
        {
            Id = null;
            Content = "No content has been entered for " + word ;
        }
    }
}
