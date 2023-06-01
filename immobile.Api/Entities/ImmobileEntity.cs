using System.ComponentModel.DataAnnotations;

using immobile.Api.Entities;

namespace immobile.Api.Entities
{

    public class ImmobileEntity
    {
        [Key]
        public int ImmobileId { get; set; }
        public int AddressId { get; set; }
        public AddressEntity? Address { get; set; }
        public ICollection<TagCommonArea_and_Immobile>? TagsCommonsArea { get; set; }
        public ICollection<TagPrivateArea_and_immobile>? TagsPrivateArea { get; set; }

        public int TagImmobileTypeId { get; set; }
        public TagImmobileTypeEntity? TagImmobileType { get; set; }
        public ICollection<TagAdvertiseType_and_immobile>? TagsAdvertiseTypes { get; set; }
        public ICollection<TagBusinessEntity>? TagsBusiness { get; set; }
        public ICollection<Contact_and_immobile>? Contacts { get; set; }
        public string? Description { get; set; }
    }
}
