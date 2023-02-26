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
        public static void Main(string[] args)
        {
            Console.WriteLine("Ceiling: " + Math.Ceiling(15.3)); //next full number
            Console.WriteLine("Floor: " + Math.Floor(15.3)); //lower whole number

            int num1 = 13;
            int num2 = 9;

            Console.WriteLine($"Lower of {num1} i {num2} is: {Math.Min(num1,num2)}" );
            Console.WriteLine($"Higher of {num1} i {num2} is: {Math.Max(num1, num2)}");

            Console.WriteLine($"3 to the power of 5 is {Math.Pow(3,5)}");
            Console.WriteLine($"PI is: {Math.PI}");
            Console.WriteLine($"The square root of 25 is {Math.Sqrt(25)}");
            Console.WriteLine($"Always positive is {Math.Abs(-25)}");
            Console.WriteLine($"cos of 1 is: {Math.Cos(1)}");
        }
    }
}