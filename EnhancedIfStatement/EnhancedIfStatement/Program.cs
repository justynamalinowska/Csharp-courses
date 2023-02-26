namespace HelloWorld;

class Statement
{


    static void Main(string[] args)
    {
        //condition ? true : flase;

        int temperature = 5;
        string stateOfMatter;

        stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

        Console.WriteLine("State of matter is " + stateOfMatter);

        Console.Read();
    }
}
