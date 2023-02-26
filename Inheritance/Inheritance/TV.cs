using System;
using Inheritance;

namespace Inheritance
{
	public class TV : ElectricalDevices
	{
		//child
		public TV(Boolean isOn, string brand) : base(isOn, brand)
        {
		}

		public void WatchTV()
		{
			if (IsOn)
			{
				Console.WriteLine("Watching TV!");
			}
			else
			{
				Console.WriteLine("TV is switched off, turn on it first");
			}
		}
	}
}

