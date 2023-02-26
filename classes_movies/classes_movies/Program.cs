using System;
using classes_movies;

namespace classes_movies
{
    class Program
    {
        static void Main(string[] args)
        {
            movies movie1 = new movies("Harry", "G");
            movies movie2 = new movies("Shreck", "PG");

            Console.WriteLine(movies.movieCount);
        }
    }
}