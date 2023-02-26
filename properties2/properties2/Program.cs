using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3,4,5);
            //box.length = 3;

            //box.SetLength(3);
            //box.Height = 4;
            //box.Width = 5;

            Console.WriteLine($"Box length is {box.GetLength()}");
            Console.WriteLine($"Box volume is {box.Volume}");
            Console.WriteLine($"Box width is {box.Width}");
            box.Width = 10;
            Console.WriteLine($"Box width is {box.Width}");
            box.DisplayInfo();
        }
    }
}