using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclasses
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Shape shape = new Shape();  we can't create new objects from abstract class

            Shape[] shapes = { new Sphere(4), new Cube(5) };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"{shape.Name} has a volume of {shape.Volume()}");

                Cube icecube = shape as Cube;

                if (icecube == null)
                {
                    Console.WriteLine("This shape is not cube");
                }

                if (icecube is Cube) //checking a type
                {
                    Console.WriteLine("This shape is cube");
                }

                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;
                Console.WriteLine(cube2.Name + " volume: " + cube2.Volume());

            }

            
        }
    }
}