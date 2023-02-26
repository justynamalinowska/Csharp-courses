namespace HelloWorld;

class Swich_Statement
{
    static void Main(string[] args)
    {
        int age = 21;

        switch (age)
        {
            case 15:
                Console.WriteLine("Too young to party in the club!");
                break;
            case 21:
                Console.WriteLine("Good to go!");
                break;
            default:
                Console.WriteLine("How old are you then?");
                break;
        }


        string username = "Justynaa";

        switch (username)
        {
            case "Justyna":
                Console.WriteLine("Username is Justyna");
                break;

            case "root":
                Console.WriteLine("Username is Justyna");
                break;

            default:
                Console.WriteLine("Username is not known");
                break;
        }


        Console.Read();

        //if (age == 15)
        //{
        //    Console.WriteLine("Too young to party in the club!");
        //}
        //else if(age ==21){
        //    Console.WriteLine("Good to go!");
        //}
        //else { 
        //        Console.WriteLine("How old are you then?");

        //}

        //Console.Read();

    }
}