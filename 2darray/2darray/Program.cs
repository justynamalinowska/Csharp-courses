using System;
using System.Xml.Linq;

namespace Coding.Exercise
{
    public class Exercise
    {
        static void Main(string[] args)
        {
            //declare 2D array
            //string[,] matrix;

            //3D
            int[,,] threeD;

            //two dimensional array
            int[,] array2D = new int[,]

            {
              // 0 1 2    //row first
                {1,2,3 }, //row 0
                {4,5,6 }, //row 1
                {7,8,9 }, //row 2
            };
            Console.WriteLine($"Central value is {array2D[2,0]}");

            string[,,] array3D = new string[,,]
             {//depth
                { //height    //their places
                    {"000", "001" }, //lenght
                    {"010", "011" },
                    {"Hi", "Bye" }
                },
                { //1 on the beggining    //row after 1
                    {"100", "101" },      //row 0
                    {"110", "111" },       //row 1
                    {"Antoher one", "Last one" }
                }
            };
            Console.WriteLine($"Value is {array3D[0,2,0]}");


            string[,] array2DString = new string[3, 2] //3 rows and 2 lines
            {
                { "one", "two"},
                { "three", "four"},
                { "five", "six"}
            };

            array2DString[2, 1] = "chicken";

            int dimensions = array2DString.Rank; //number of diamentions in array

            Console.WriteLine(array2DString[2, 1] + dimensions);

            int[,] matrix =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };


            ////write evry single number from array
            //foreach (int i in matrix)
            //{
            //    Console.Write(i + " ");
            //};

            //Console.WriteLine("This is our 2D array printed using nested for loop");


            ////outer for loop
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    //inner for loop
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        if (i == j)
            //            Console.Write(matrix[i, j] + " ");
            //        else
            //            continue;
            //    }

            //}




            //goes trought each element in the diagonal
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                Console.WriteLine(matrix[k,k]);
            }


            for (int j = 0, m=2; j < matrix.GetLength(0); j++, m--)
            {
                Console.WriteLine(matrix[j,m]);
            }











        }
    }
}