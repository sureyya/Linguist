using System.Collections.Generic;

namespace Linguist.Model
{
    public class Article :EntityBase
    {
        public Article()
        {
            Sentences = new List<Sentence>();
        }        

        public string Title { get; set; }

        public string Description { get; set; }        

        public IList<Sentence> Sentences { get; set; }

    }
}