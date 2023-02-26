using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            string pattern = @"\d";
            Regex regex = new Regex(pattern);

            string text = "Hi my number is 456787654 :) ";

            MatchCollection matchCollection = regex.Matches(text);

            Console.WriteLine($"{matchCollection.Count} hits found: \n {text}");

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;

                Console.WriteLine($"{group[0].Value} foun at {group[0].Index}");

            }
        }
    }
}