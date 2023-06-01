namespace immobile.Api.Entities
{
    public class Contact_and_immobile
    {
        public int ContactId { get; set; }
        public ContactEntity? Contact { get; set; }

        public int ImmobileId { get; set; }
        public ImmobileEntity? Immobile { get; set; }
    }
}
