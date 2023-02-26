using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numberList = new List<int>() { 9, 6, 2 };
            int[] numberArray = new int[] { 1, 7, 1, 3 };

            Console.WriteLine(" ");

            CollectionSum(numberList);
            CollectionSum(numberArray);
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;

            foreach (int num in anyCollection)
            {
                sum += num;
            }
            Console.WriteLine($"Sum is {sum}");
        }
    }
}