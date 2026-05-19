namespace ProjectSuperhero.Models
{
    public class Serie
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string WikipediaLink { get; set; }
    }
}