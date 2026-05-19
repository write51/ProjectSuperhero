namespace ProjectSuperhero.Models
{
    public class Comic
    {
        public long Id { get; set; }
        public long SeriesId { get; set; }
        public required string Name { get; set; }
        public long Number { get; set; }
        public required string Cover { get; set; }
        public DateTime ReleaseDate { get; set; }
        public required string Resource { get; set; }
        public long Rating { get; set; }
        public string OtherName { get; set; }
        public string Genres { get; set; }
        public string Publisher { get; set; }
        public string Writer { get; set; }
        public string Artist { get; set; }
        public string PublicationDate { get; set; }
        public string Summary { get; set; }

    }
}