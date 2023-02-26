using System;
using System.Globalization;

namespace Zadanie_ParametryTrojkata
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            string[] array = Console.ReadLine().Split("; ");
            Array.Sort(array);
            double a = double.Parse(array[0]);
            double b = double.Parse(array[1]);
            double c = double.Parse(array[2]);


            //Console.WriteLine($"{a} {b} {c}");
            if (a <= 0 || b <= 0 || c <= 0)
            { Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!"); }
            else if (a > b + c || b > a + c || c > a + b)
            { Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!"); }
            else
            {
                double p = (a + b + c) / 2;
                double obwód = a + b + c;
                double pole = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                string typ = "nieznany";

                if ((a * a) + (b * b) == (c * c))
                {
                    typ = "prostokątny";
                }
                else if ((a * a) + (b * b) < (c * c))
                {
                    typ = "rozwartokątny";
                }
                else if ((a * a) + (b * b) > (c * c))
                {
                    typ = "ostrokątny";
                }
                Console.WriteLine("obwód = "+ obwód.ToString("F", CultureInfo.InvariantCulture));
                Console.WriteLine("pole = "+ pole.ToString("F", CultureInfo.InvariantCulture));
                Console.WriteLine($"trójkąt jest {typ}");
                if (a == b && b == c)
                {
                    Console.WriteLine("trójkąt równoboczny");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("trójkąt równoramienny");
                }
            }
        }
    }
}