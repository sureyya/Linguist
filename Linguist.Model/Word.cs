using System.Collections.Generic;

namespace Linguist.Model
{
    public class Word :EntityBase
    {
        public Word()
        {
            Translations = new List<Translation>();
        }
        public int Order { get; set; }

        public string Text { get; set; }

        public IList<Translation> Translations { get; set; }
    }
}