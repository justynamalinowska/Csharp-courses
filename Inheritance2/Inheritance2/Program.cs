using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Post post1 = new Post("Thanks you for the birthday wishes", true, "Justyna Malinowska");
            Console.WriteLine(post1.ToString()); //to string - quick brief about object

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", true, "http...", "Justyna Malinowska");
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("Vlog from London", true, "htttp...", 10, "Justyna Malinowska");
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop th video!");
            Console.ReadKey();
            videoPost1.Stop();
        }
    }
}
