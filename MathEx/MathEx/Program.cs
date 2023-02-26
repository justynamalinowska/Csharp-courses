using System;

namespace Coding.Exercise
{

    public class Exercise
    {
        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        public static void Run(string line)
        {
            int lineInt;

            if (Int32.TryParse(line, out lineInt) == true && lineInt > 0 && lineInt < 180)
            {
                Console.WriteLine($"Cos = {Math.Cos(ConvertToRadians(lineInt))}");
                Console.WriteLine($"Sin = {Math.Sin(ConvertToRadians(lineInt))}");
                Console.WriteLine($"Tg = {Math.Tan(ConvertToRadians(lineInt))}");
            }
            else
            {
                Console.WriteLine("Check the input!");
            }
        }
    }
}
