using System;
namespace creating_Interfaces
{
	public class Vehical
	{
		public float Speed { get; set; }
		public string Color { get; set; }

		public Vehical()
		{
			Speed = 120f;
			Color = "White";
		}

        public Vehical(float speed, string color)
        {
			this.Speed = speed;
			this.Color = color;
        }
    }
}

