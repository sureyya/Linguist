using System.Collections.Generic;

namespace Linguist.DTOs
{
    public class ArticleDTO :EntityDTO
    {
        public ArticleDTO()
        {
            Sentences = new List<SentenceDTO>();
        }        

        public string Title { get; set; }

        public string Description { get; set; }        

        public IEnumerable<SentenceDTO> Sentences { get; set; }

    }
}