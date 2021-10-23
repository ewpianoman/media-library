using System;
using Pianoman.MediaLibrary;

namespace media_library
{
    class Program
    {
        static void Main(string[] args)
        {
            Album album = new Album("The Stranger", "Billy Joel", "Rock");

            AudioBook audioBook = new AudioBook("The Shining", "Stephen King", "Horror");

            Book book = new Book("The Dead Zone", "Stephen King", 428, "Paperback", "Scince Fiction, Thriller");

            EBook eBook = new EBook("11/22/63", "Stephen King", 849, "ePUB", "Science Fiction, Alternate History");

            Movie movie = new Movie("The Pacifier", "March 4, 2005", "Vin Diesel, Lauren Graham, Faith Ford, Brittany Snow, Max Thieriot, Carol Kane, Brad Garrett", "Comedy, Family", "95 minutes");
        
            Console.WriteLine($"Album: {album.Title} by {album.Artist}, genre is {album.Genre}.");
            Console.WriteLine($"Audiobook: {audioBook.Title} by {audioBook.Author}, genre is {audioBook.Title}, length is {audioBook.Length} minutes.");
            Console.WriteLine($"EBook: {eBook.Title} by {eBook.Author}, genre is {eBook.Genre}, page count is {eBook.PageCount}.");
            Console.WriteLine($"Movie: {movie.Title} actors {movie.Actors}, genre is {movie.Genre}, length is {movie.Length}.");
        }
    }
}
