namespace ExemploWebAPI.Models
{
    public class Specifications
    {
        public Specifications(string originallyPublished, string author, long pageCount, Genres illustrator, Genres genres)
        {
            OriginallyPublished = originallyPublished;
            Author = author;
            PageCount = pageCount;
            Illustrator = illustrator;
            Genres = genres;
        }
        public string OriginallyPublished { get; set; }
        public string Author { get; set; }
        public long PageCount { get; set; }
        public Genres Illustrator { get; set; }
        public Genres Genres { get; set; }
    }
}