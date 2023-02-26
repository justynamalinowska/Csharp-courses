using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properities;

class Program
{

    static void Main(string[] args)
    {
        Box box = new Box(3,4,5);
        //box.length = 3;
        //box.SetLength(4);
        //box.width = 4;
        //box.Height = -5;


       Console.WriteLine("Box s Width is " + box.Width);
        box.Width = 10;
       Console.WriteLine("Box s volume is " + box.Volume);

        box.DisplayInfo();
    }
}