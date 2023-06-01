namespace immobile.Api.Entities
{
    public class TagAdvertiseType_and_immobile
    {
        public int TagAdvertiseTypeId { get; set; }
        public TagAdvertiseTypeEntity? TagAdvertiseType { get; set; }

        public int ImmobileId { get; set; }
        public ImmobileEntity? Immobile { get; set; }
    }
}
