namespace immobile.Api.Entities
{
    public class TagPrivateArea_and_immobile
    {
        public int TagPrivateAreaId { get; set; }
        public TagPrivateAreaEntity? TagPrivateArea { get; set; }

        public int ImmobileId { get; set; }
        public ImmobileEntity? Immobile { get; set; }
    }
}
