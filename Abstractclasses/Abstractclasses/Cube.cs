using System;
namespace Abstractclasses
{
	public class Cube : Shape
	{
        public double Length { get; set; }


        public Cube(double length)
		{
            Name = "Cube";
            this.Length = length;
		}

        public override double Volume()
        {
            return Math.Pow(Length,3);
        }

        public override void GetInfo() // we can override
        {
            base.GetInfo();
            Console.WriteLine($"The cube has a length: {Length}");
        }
    }
}

