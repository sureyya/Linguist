using System;

namespace Linguist.Model
{
    public abstract class EntityBase
    {
        public  Guid? Id { get; set; }

        private DateTime? dateCreated;
        public DateTime? DateCreated
        {
            get {return dateCreated ?? DateTime.Now;
            }
            set { dateCreated = value; }
        }
    }
}