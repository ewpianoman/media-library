using System;
using Pianoman.MediaLibrary;

namespace media_library
{
    class Program
    {
        static void Main(string[] args)
        {
            Album album = new Album();
            album.Title = "The Stranger";
            album.Artist = "Billy Joel";
            album.ReleaseDate = "1977";
            album.Label = "Columbia Records";
            album.Format = "Vinyl";
            album.Genre = "Rock";

            AudioBook audioBook = new AudioBook();
            audioBook.Title = "The Shining";
            audioBook.Author = "Stephen King";
            audioBook.Format = "MP3";
            audioBook.Genre = "Horror";
            audioBook.Length = "15 Hours, 50 Minutes";
            audioBook.PerformedBy = "Campbell Scott";
            audioBook.PublishDate = "1977";
            audioBook.Publisher = "Doubleday";

            Book book = new Book();
            book.Title = "The Dead Zone";
            book.Author = "Stephen King";
            book.Format = "Paperback";
            book.Genre = "Science Fiction, Thriller";
            book.PageCount = 428;
            book.PublishDate = "1979";
            book.Publisher = "Viking Press";

            EBook eBook = new EBook();
            eBook.Author = "Stephen King";
            eBook.Title = "11/22/63";
            eBook.Format = "ePUB";
            eBook.Genre = "Science Fiction, Alternate History";
            eBook.PageCount = 849;
            eBook.PublishDate = "2011";
            eBook.Publisher = "Scribner";

            Movie movie = new Movie();
            movie.Title = "The Pacifier";
            movie.Studio = "Walt Disney Pictures, Spyglass Entertainment";
            movie.Director = "Adam Shankman";
            movie.Editor = "Christopher Greenbury";
            movie.Genre = "Comedy, Family";
            movie.Length = "95 minutes";
            movie.Producers = "Roger Birnbaum, Gary Barber, Jonathan Glickman";
            movie.ReleaseDate = "March, 4, 2005";
            movie.Actors = "Vin Diesel, Lauren Graham, Faith Ford, Brittany Snow, Max Thieriot, Carol Kane, Brad Garrett";
        }
    }
}
