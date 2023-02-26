using System;
namespace Inheritance
{
	public class ElectricalDevices 
	{
        //parent - ElectricalDevices
        public Boolean IsOn { get; set; }
        public string Brand { set; get; }

        //      public ElectricalDevices(bool IsOn, string Brand)
        //{
        //          this.IsOn = IsOn;
        //          this.Brand = Brand;
        //      }

        //Beter way to write constructor (?)
        public ElectricalDevices(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        public void SwichOn()
        {
            IsOn = true;
        }

        public void SwichOff()
        {
            IsOn = false;
        }

    }
}

