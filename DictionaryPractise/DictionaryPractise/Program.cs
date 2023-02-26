using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise
{
    public class Speller
    {
        static void Main(string[] args)
        {
            int i = 2;
            Convert(i);
        }
        public static string Convert(int i)
        {
            Numbers[] numbers =
            {
                new Numbers(0 , "zero"),
                new Numbers(1, "one"),
                new Numbers(2, "two"),
                new Numbers(3, "three"),
                new Numbers(4, "four"),
                new Numbers(5, "five"),
            };

            Dictionary<int, Numbers> numbersDictionary = new Dictionary<int, Numbers>();

            foreach (Numbers number in numbers)
            {
                numbersDictionary.Add(number.Key, number);
            };

            Numbers result = null;
            if (numbersDictionary.TryGetValue(i, out result))
            {
                return result.Value;
            }
            else
            {
                return "nope";
            }
        }

    }
    class Numbers
    {
        public int Key { get; set; }
        public string Value { get; set; }


        public Numbers(int Key, string Value)
        {
            this.Key = Key;
            this.Value = Value;
        }
    }

}
