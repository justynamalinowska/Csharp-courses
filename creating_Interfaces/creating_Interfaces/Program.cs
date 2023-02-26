using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_Interfaces
{
    class Program
    {
        public static void Main(string[] args)
        {
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            Car damagedCar = new Car(80f, "Blue");

            //we add two chairs near this damaged car
            damagedCar.DestroyablesNearbly.Add(officeChair);
            damagedCar.DestroyablesNearbly.Add(gamingChair);


            damagedCar.Destroy();
        }
    }
}
