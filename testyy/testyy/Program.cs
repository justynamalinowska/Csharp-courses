using System;
using System.Xml.Linq;

namespace Coding.Exercise
{
    public class Exercise
    {
        static void Main(string[] args)
        {

            Boolean valid = false;
            string inputValueType;

            Console.WriteLine("Input value: ");
            string value = Console.ReadLine();

            Console.WriteLine( "What is the data type of your value?" + System.Environment.NewLine + " -Press 1 for String" + System.Environment.NewLine + " -Press 2 for Intiger" + System.Environment.NewLine + " -Press 3 for Boolen");
            int value2 = int.Parse(Console.ReadLine());

            switch (value2)
            {
                case 1:
                    {
                        valid = IsAllAlphabetic(value);
                        inputValueType = "String";
                        break;
                    }

                case 2:
                    {
                        int retValue = 0;
                        valid = int.TryParse(value, out retValue);
                        inputValueType = "Intiger";
                        break;
                    }


                case 3:
                    {
                        bool retFlag = false;
                        valid = bool.TryParse(value, out retFlag);
                        inputValueType = "Boolean";
                        break;
                    }
                default:
                    inputValueType = "unknown";
                    Console.WriteLine("Not able to detect the input type, something is wrong");
                    break;
            }

            Console.WriteLine($"You have entered a value :{value}");
            if (valid)
            {
                Console.WriteLine($"It is valid : {inputValueType}");
            }
            else
            {
                Console.WriteLine($"it is an invalid : {inputValueType}");
            }





            static bool IsAllAlphabetic(string inputValue)
            {
                foreach (char c in inputValue)
                {
                    if (!char.IsLetter(c))
                        return false;
                }
                return true;
            }


        }
    }
}