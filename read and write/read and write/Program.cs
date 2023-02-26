using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            using (StreamReader sr = new StreamReader(@"/Users/justynamalinowska/Downloads/input.txt"))
            {
                
                using (StreamWriter sw = new StreamWriter(@"/Users/justynamalinowska/Downloads/output.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        
                        if (line.Contains("split"))
                        {
                            
                            string[] splittedLine = line.Split(' ');
                            
                            sw.Write(" " + splittedLine[4]);
                        }
                    }
                }
            }
        }
    }
}