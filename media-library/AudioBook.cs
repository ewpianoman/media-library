namespace Pianoman.MediaLibrary
{
    class AudioBook
    {
        public readonly string Title;
        public readonly string Author;
        public readonly string Length;
        public readonly string Genre;
        public readonly string PerformedBy;

        public AudioBook(string title, string author, string length, string genre, string performedBy)
        {
            Title = title;
            Author = author;
            Length = length;
            Genre = genre;
            PerformedBy = performedBy;
        }

        public AudioBook(string title, string author, string genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }

        public AudioBook(string title)
        {
            Title = title;
        }
    }
}