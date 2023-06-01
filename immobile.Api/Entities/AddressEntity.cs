using System.ComponentModel.DataAnnotations;


namespace immobile.Api.Entities;
public class AddressEntity{

    [Key]
    public int AddressId { get; set; }
    public string? District { get; set; }
    public string? Postal_code { get; set; }
    public string? Street { get; set; }
    public string? State { get; set; }
    public string? City { get; set; }


}