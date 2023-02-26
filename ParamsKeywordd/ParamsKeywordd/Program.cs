using System;
using System.Xml.Linq;

namespace ParamsKeyword
{
    public class Program
    {

        static void Main(string[] args)
        {

            int min = Minv2(4, 3, 5, 6, -7, 13);
            Console.WriteLine(min);



        }

        public static int Minv2(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }




        static void ParamsMethod()
        {
            Params("This", "is", "a", "long", "string.");

            float pi = 3.14f;
            Params2(pi, "hello", 5.3, '$');
        }

        public static void Params(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }


        //arrays with objects
        public static void Params2(params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.Write(obj + " ");
            }
        }
    }
}