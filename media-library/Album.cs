namespace Pianoman.MediaLibrary
{
    class Album
    {
      public readonly string Title;
      public readonly string Artist;
      public readonly string Genre;

      public Album(string title, string artist, string genre)
      {
        Title = title;
        Artist = artist;
        Genre = genre;
      }
    }
}