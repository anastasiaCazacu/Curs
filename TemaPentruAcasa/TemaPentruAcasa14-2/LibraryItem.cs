namespace TemaPentruAcasa14_2
{
    public class LibraryItem(string title,
                       string author,
                       int publicationYear)
    {
        public string Title { get; set; } = title;
        public string Author { get; set; } = author;
        public int PublicationYear { get; set; } = publicationYear;
    }
}
