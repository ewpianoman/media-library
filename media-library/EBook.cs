namespace Pianoman.MediaLibrary
{
    class EBook : Book
    {
      public readonly string Title;
      public readonly string Author;
      public readonly int PageCount;
      public readonly string Format;
      public readonly string Genre;

      public EBook(string title, string author, int pageCount, string format, string genre) : base(title, author, pageCount, format, genre)
      {
        Title = title;
        Author = author;
        PageCount = pageCount;
        Format = format;
        Genre = genre;
      }

      public EBook(string title, string author, string genre) : base(title, author, genre)
      {
        Title = title;
        Author = author;
        Genre = genre;
      }

      public EBook(string title, string author) : base(title, author)
      {
        Title = title;
        Author = author;
      }
    }
}