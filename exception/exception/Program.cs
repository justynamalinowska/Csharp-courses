string age = Console.ReadLine();

try
{
    int intAge = int.Parse(age);
}
//catch (OverflowException)
//{
//    //throw;
//    Console.WriteLine("przepełnienie danych");
//}
//catch(FormatException)
//{
//    Console.WriteLine("type");
//}
//catch(ArgumentNullException)
//{
//    Console.WriteLine("null");
//}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}