using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeyword
{
    public class Program
    {

        static void Main(string[] args)
        {
            //declaring an arraylist
            ArrayList myArrayList = new ArrayList();
            ArrayList myArrayList2 = new ArrayList(20); //with 20 objects


            myArrayList.Add(25);
            myArrayList.Add("Hi");
            myArrayList.Add(55);
            myArrayList.Add(100);
            myArrayList.Add('%');
            myArrayList.Add(40);


            //remove spectific value
            myArrayList.Remove(25);

            //delete elements from index
            myArrayList.RemoveAt(2);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else
                {
                    Console.WriteLine(obj); ;
                }
            }
            Console.WriteLine(sum);
        }
    }
}