namespace ProjectSuperhero.Models
{
    public class Comic
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public long Number { get; set; }
        public required string Cover { get; set; }
        public DateTime ReleaseDate { get; set; }
        public required string Resource { get; set; }
        public long Rating { get; set; }

    }
}