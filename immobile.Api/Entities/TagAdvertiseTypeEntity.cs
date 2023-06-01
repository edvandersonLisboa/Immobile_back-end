using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace immobile.Api.Entities
{
    public class TagAdvertiseTypeEntity
    {
        [Key]
        public int TagAdvertiseTypeId { get; set; }
        public string? name { get; set; }
        public ICollection<TagAdvertiseType_and_immobile>? Immobile { get; set; }
    }
}
