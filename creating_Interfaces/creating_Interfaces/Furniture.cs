using System;
namespace creating_Interfaces
{
	public class Furniture
	{
		public string Color { get; set; }
		public string Material { get; set; }

		//default constructor
		public Furniture()
		{
			Color = "White";
			Material = "Wood";
		}

		//simple constructor
        public Furniture(string color, string material)
        {
			Color = color;
			Material = material;
        }
    }
}

