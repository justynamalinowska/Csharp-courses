using System;
using Inheritance;

namespace Inheritance
{

    //child/base - radio 
	public class Radio : ElectricalDevices //radio inherite from ele d
	{

        public Radio(bool isOn, string brand) : base(isOn, brand)
        { }

        public void ListeningMusic()
        {
            if (IsOn)
            {
                Console.WriteLine("lalalalallalalal");
            }
            else
            {
                Console.WriteLine("Radio is switched off, turn on it first");
            }
        }
    }
}

