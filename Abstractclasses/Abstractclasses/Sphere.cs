using System;
namespace Abstractclasses
{
	public class Sphere : Shape
	{
		public double R { get; set; } //Radius


		public Sphere(double r)
		{
			Name = "Sphere";
			this.R = r;
		}

        public override double Volume()
        {
            return (4/3 * Math.PI * Math.Pow(R,3));
        }

        public override void GetInfo()
        {
            base.GetInfo();
			Console.WriteLine($"R={R}, so volume is equal to {Volume()}");
        }
    }
}

