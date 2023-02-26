using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic_Parameters
{
    class Program
    {
        public static void Main(string[] args)
        {
            var cars = new List<Car>
            {
             new Audi("RS3", 322, "baby blue"),
             new BMW("x4", 245, "black"),
             new Audi("A4", 200, "red"),
             new BMW("x3", 220, "white"),

            };

            foreach (var car in cars)
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW("Z3", 200, "black"); //type-car so ShowDetails() for cars
            Car audiA3 = new Audi("A3", 220, "green");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            bmwZ3.SetCarIdInfo(2, "Mateusz Malinowski");
            audiA3.SetCarIdInfo(3, "Jkaub Burek");
            bmwZ3.GetCarIdinfo();
            audiA3.GetCarIdinfo();

            BMW bmwM5 = new BMW("Sport", 300, "yellow");
            Car carb = (Car)bmwM5;  //we change type- bmw for car 
            carb.ShowDetails();     //type-car so ShowDetails() for cars

            M3 m3 = new M3("M3 turbo", 260, "red");
            m3.Repair();
        }
    }
}