using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace immobile.Api.Entities
{
    public class TagImmobileTypeEntity
    {
        [Key]
        public int TagImmobileTipeId { get; set; }
        public string? name { get; set; }
        public ICollection<ImmobileEntity>? Immobile { get; set; }
    }
}
