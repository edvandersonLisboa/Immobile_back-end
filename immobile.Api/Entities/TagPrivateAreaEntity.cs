using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace immobile.Api.Entities
{
    public class TagPrivateAreaEntity
    {
        [Key]
        public int TagPrivateAreaId { get; set; }
        public string? name { get; set; }
        public ICollection<TagPrivateArea_and_immobile>? Immobile { get; set; }
    }
}
