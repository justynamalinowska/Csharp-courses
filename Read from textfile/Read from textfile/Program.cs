using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project
{
    class Program
    {
        public static void Main(string[] args)
        {
            //write into a text file
            //method 1
            string[] lines2 = { "250", "242", "240" };
            File.WriteAllLines(@"/Users/justynamalinowska/Downloads/highscores.txt", lines2);
            
            //method 2 
            Console.WriteLine("Please give the file a name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please give the text for file");
            string input = Console.ReadLine();

            File.WriteAllText(@"/Users/justynamalinowska/Downloads/" + fileName + ".txt", input);
            
            //method 3
            using (StreamWriter file = new StreamWriter(@"/Users/justynamalinowska/Downloads/myText.txt"))
            {
                foreach (string line in lines2)
                {
                    if (line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"/Users/justynamalinowska/Downloads/myText.txt"))
            {
                file.WriteLine("Additional line");
            }


            //Reading from file
            //example 1
            string text = System.IO.File.ReadAllText(@"/Users/justynamalinowska/Downloads/textFile.txt");

            Console.WriteLine("Text file contains following text: " + text);
            //example 2
            string[] lines = System.IO.File.ReadAllLines(@"/Users/justynamalinowska/Downloads/textFile.txt");
            Console.WriteLine("Contetsc of textFile.txt");

            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }



        }
    }
}
