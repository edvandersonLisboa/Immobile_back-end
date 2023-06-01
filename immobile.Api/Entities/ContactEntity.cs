using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace immobile.Api.Entities;

public class ContactEntity
{
    [Key]
    public int ContactId { get; set; }
    public string? Name { get; set; }
    public string? DDD { get; set; }
    public string? DDI { get; set; }
    public string? Number { get; set; }

    public IList<Contact_and_immobile>? Immobile { get; set; }
}
