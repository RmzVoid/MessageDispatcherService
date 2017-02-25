using System.Data.Entity;

using DatabaseLayer.Entities;
using DatabaseLayer.Initializer;

namespace DatabaseLayer.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=TestTaskConnectionString")
        {
            Database.SetInitializer(new DatabaseInitializer<DatabaseContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EventTypeConfiguration());
            modelBuilder.Configurations.Add(new SubscriptionConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
    }
}
