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
            IEnumerable<int> unknowncolletion;
            unknowncolletion = GetCollection(1);

            Console.WriteLine("This was a List<int>");
            foreach (int num in unknowncolletion)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("");

            unknowncolletion = GetCollection(2);
            Console.WriteLine("This was a Queue<int>");
            foreach (int num in unknowncolletion)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("");

            Console.WriteLine("This was array of ints");
            unknowncolletion = GetCollection(5);
            foreach (int num in unknowncolletion)
            {
                Console.Write(num + " ");
            }

        }

        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numberlist = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if (option == 1)
            {
                return numberlist;
            }
            else if (option == 2 )
            {
                return numbersQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }
        }

    }

    

}