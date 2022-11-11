namespace NZWalks.API.Models.Domain
{
    public class Walk
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }

        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }

        //Navigation property
        //When we run migrations, Entity Framework will establish a connection between the objects
        public Region Region { get; set; }
        public WalkDifficulty WalkDifficulty { get; set; }

    }
}
