using System;
namespace Properities

{
    public class Box
    {
        public int Height { get; set; }
        public int Length { get; set; }
        public int FrontSurface {
            get
            { return Height * Length; }
        }

        public Box(int height, int length)
        {
            Height = height;
            Length = length;
        }

        public void Size()
        {
            Console.WriteLine($"Height is {Height} and length {Length} so the front surface is {FrontSurface}");
        }
    }
}

