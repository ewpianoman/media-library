namespace Pianoman.MediaLibrary
{
    class Book
    {
      public readonly string Title;
      public readonly string Author;
      public readonly int PageCount;
      public readonly string Format;
      public readonly string Genre;

      public Book(string title, string author, int pageCount, string format, string genre)
      {
        Title = title;
        Author = author;
        PageCount = pageCount;
        Format = format;
        Genre = genre;
      }

      public Book(string title, string author, string genre)
      {
        Title = title;
        Author = author;
        Genre = genre;
      }

      public Book(string title, string author)
      {
        Title = title;
        Author = author;
      }
    }
}