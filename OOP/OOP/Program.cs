using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP;

class Program
{


    static void Main(string[] args)
    {
        //create an object of my class
        //an instance of Human

        //Human Denis = new Human();

        ////access public variable from outside
        ///
        //Denis.firstName = "Denis";

        //Denis.lastName = "Kowalski";

        ////call methods of the class

        //Denis.IntroduceMyself();


        Human Sissy = new Human("Sissy", "Trump", "blue", 18);
        Sissy.IntroduceMyself();
        Human Zuza = new Human("Zuza", "Smith", "grey");
        Zuza.IntroduceMyself();
        Human Ania = new Human("Ania", "Smith");
        Ania.IntroduceMyself();
        Human Basia = new Human("Basia");
        Basia.IntroduceMyself();



        Human basicHuman = new Human();
        basicHuman.IntroduceMyself();


        Console.ReadKey();
    }

}
