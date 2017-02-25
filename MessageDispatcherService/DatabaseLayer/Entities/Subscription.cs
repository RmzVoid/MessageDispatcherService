using System.Data.Entity.ModelConfiguration;

namespace DatabaseLayer.Entities
{
    public class Subscription : EntityBase
    {
        public EventType Event { get; set; }
        public User User { get; set; }
    }

    public class SubscriptionConfiguration : EntityTypeConfiguration<Subscription>
    {
        public SubscriptionConfiguration()
        {
            HasKey(f => f.Id);
            HasRequired(f => f.Event);
            HasRequired(f => f.User);
        }
    }
}
