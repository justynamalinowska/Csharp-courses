using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_Interfaces
{
    class Program
    {
        struct Game
        {
            public string Name;
            public string Developer;
            public string ReleaseDate;
            public string Rating;

            public void Display()
            {
                Console.WriteLine($"Game 1's name is: {Name}");
                Console.WriteLine($"Game 1 was developed by: {Developer}");
                Console.WriteLine($"Game 1's rating is: {Rating}");
                Console.WriteLine($"Game 1 was released in: {ReleaseDate}");
            }

        }
        public static void Main(string[] args)
        {
            Game game1;

            game1.Name = "HogwardLegacy";
            game1.Developer = "Justyna Malinowska";
            game1.Rating = "4.5/5";
            game1.ReleaseDate = "11.12.2023";

            game1.Display();

            
        }
    }
}