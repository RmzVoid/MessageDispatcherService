using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Entities
{
    public abstract class EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
