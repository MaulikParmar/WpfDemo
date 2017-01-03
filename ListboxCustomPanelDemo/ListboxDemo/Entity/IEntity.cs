using System;

namespace ListboxDemo.Entity
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
    }

    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
