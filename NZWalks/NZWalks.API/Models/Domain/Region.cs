namespace NZWalks.API.Models.Domain
{
    public class Region
    {
        public Guid id { get; set; }
        public string Code { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long Population { get; set; }

        //Navigation property
        //When we run migrations, Entity Framework will establish a connection between the objects
        public IEnumerable<Walk> Walks { get; set; } //One region can have multiple walks

    }
}
