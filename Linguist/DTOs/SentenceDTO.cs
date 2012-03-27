using System.Collections.Generic;

namespace Linguist.DTOs
{
    public class SentenceDTO :EntityDTO
    {
        public SentenceDTO()
        {
            Words = new List<WordDTO>();
        }        

        public IEnumerable<WordDTO> Words { get; set; }
    }
}