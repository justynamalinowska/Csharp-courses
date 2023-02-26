using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Random dice = new Random();
            //int numEyes;

            //for (int i = 0; i < 10; i++)
            //{
            //    numEyes = dice.Next(1,7);
            //    Console.WriteLine(numEyes);
            //}

            Console.WriteLine("Should I be mad for Jakub?");

            Random random = new Random();
            int decision;

            decision = random.Next(1, 4);

            if (decision == 1)
            {
                Console.WriteLine("Yes");
            }
            else if (decision == 2)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Maybe");
            };
        }
    }
}