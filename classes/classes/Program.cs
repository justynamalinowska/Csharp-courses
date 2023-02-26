using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classes;

namespace Classes
{
class Program
    {
        static void Main(string[] args)
        {
            //I created object of my class / instance of human
            Human Justyna = new Human("Justyna", "Malinowska", "blue", 20);

            //acces public variable from outside and change it


            //Justyna.firstName = "Justyna";
            //Justyna.lastName = "Malinowska";


            //call method of the class
            Justyna.IntroduceMyself();


            Human Kuba = new Human("Kuba", "Burek", "green", 1);

            //this is equal to thist^

            //Human Kuba = new Human();
            //Kuba.firstName = "Kuba";
            //Kuba.lastName = "Burek";


            Kuba.IntroduceMyself();



            Console.ReadKey();

        }

    }
}