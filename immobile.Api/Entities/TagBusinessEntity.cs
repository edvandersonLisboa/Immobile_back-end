using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace immobile.Api.Entities
{
    public class TagBusinessEntity
    {
        [Key]
        public int TagBusinessId { get; set; }
        public string? name { get; set; }
        public int ImmobileId { get; set; }
        public ImmobileEntity? Immobile { get; set; }

        public int PriceId { get; set; }
        public PriceEntity? Price { get; set; }
    }
}
