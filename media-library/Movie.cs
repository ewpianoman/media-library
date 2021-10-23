namespace Pianoman.MediaLibrary
{
    class Movie
    {
      public readonly string Title;
      public readonly string Director;
      public readonly string ReleaseDate;
      public readonly string Actors;
      public readonly string Studio;
      public readonly string Genre;
      public readonly string Length;

      public Movie(string title, string director, string releaseDate, string actors, string studio, string genre, string length)
      {
        Title = title;
        Director = director;
        ReleaseDate = releaseDate;
        Actors = actors;
        Studio = studio;
        Genre = genre;
        Length = length;
      }

      public Movie(string title, string releaseDate, string actors, string genre, string length)
      {
        Title = title;
        ReleaseDate = releaseDate;
        Actors = actors;
        Genre = genre;
        Length = length;
      }

      public Movie(string title, string genre, string length)
      {
        Title = title;
        Genre = genre;
        Length = length;
      }
    }
}