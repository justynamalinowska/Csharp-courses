using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            //base method
            myRadio.SwichOn();
            //child method
            myRadio.ListeningMusic();

            TV myTV = new TV(false, "Samsung");
            myTV.SwichOn();
            myTV.WatchTV();
            myTV.SwichOff();

        }
    }
}

