using System.Data.Entity.ModelConfiguration;

namespace DatabaseLayer.Entities
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(f => f.Id);
            Property(f => f.Name).IsRequired();
            Property(f => f.Email).IsRequired();
            Property(f => f.Phone).IsRequired();
        }
    }
}
