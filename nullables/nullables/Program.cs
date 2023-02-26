using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Nullables //values can be empty or assigned
{
    class Program
    {
        public static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 4.14157;

            bool? boolval = new bool?();

            Console.WriteLine($"Our nubers are: {num1}, {num2}, {num3}, {num4}.");
            Console.WriteLine($"The nullable boolean value is: {boolval}");


            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("User is male");
            }
            else if (isMale == false)
            {
                Console.WriteLine("User is female");
            }
            else
            {
                Console.WriteLine("No gender chosen");
            }

            double? num6 = 13.1;
            double? num7 = null;
            double num8;

            if (num6 == null)
            {
                num8 = 0.0;
            }
            else
            {
                num8 = (double)num6;
            }
            Console.WriteLine("num8: " + num8);

            //instead of this we can use THE NULL COALESCING OPERATOR ??
            num8 = num6 ?? 8.53;
            Console.WriteLine("num8: " + num8);

            num8 = num7 ?? 8.53;
            Console.WriteLine("num8: " + num8);
        }
    }
}