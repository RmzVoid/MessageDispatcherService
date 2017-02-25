using System.Data.Entity.ModelConfiguration;

namespace DatabaseLayer.Entities
{
    public class EventType : EntityBase
    {
        public string Name { get; set; }
    }

    public class EventTypeConfiguration : EntityTypeConfiguration<EventType>
    {
        public EventTypeConfiguration()
        {
            HasKey(f => f.Id);
            Property(f => f.Name).IsRequired().HasMaxLength(32);
        }
    }
}
