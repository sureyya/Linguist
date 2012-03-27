using System;

namespace Linguist.DTOs
{
    public abstract class EntityDTO
    {
        public  Guid Id { get; set; }

        private DateTime? dateCreated;
        public DateTime? DateCreated
        {
            get {return dateCreated ?? DateTime.Now;
            }
            set { dateCreated = value; }
        }
    }
}