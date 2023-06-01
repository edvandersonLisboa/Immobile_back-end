using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace immobile.Api.Entities
{
   
    public class TagCommonAreaEntity
    {
        [Key]
        public int TagCommonAreaId { get; set; }
        public string? name { get; set; }
        public ICollection<TagCommonArea_and_Immobile>? Immobile { get; set; }
    }
}
