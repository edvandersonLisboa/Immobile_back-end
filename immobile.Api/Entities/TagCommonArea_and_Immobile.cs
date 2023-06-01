namespace immobile.Api.Entities
{
    public class TagCommonArea_and_Immobile
    {
        public int TagCommonAreaId { get; set; }
        public TagCommonAreaEntity? TagCommonArea { get; set; }

        public int ImmobileId { get; set; }
        public ImmobileEntity? Immobile { get; set; }
    }
}
