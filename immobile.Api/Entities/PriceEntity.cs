using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace immobile.Api.Entities
{
  
    public class PriceEntity
    {
        [Key]
        public int PriceId { get; set; }
        public double Value { get; set; }

    }
}
