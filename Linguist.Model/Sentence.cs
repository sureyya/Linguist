using System.Collections.Generic;

namespace Linguist.Model
{
    public class Sentence :EntityBase 
    {
        public Sentence()
        {
            Words = new List<Word>();
        }

        public int Order { get; set; }

        public IList<Word> Words { get; set; }
    }
}