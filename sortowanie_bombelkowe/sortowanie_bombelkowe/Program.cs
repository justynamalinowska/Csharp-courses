using System;

namespace BubbleSort
{
    class Program
    {
        static void Main()
        {
            int[] array = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            int[] array2 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

            if (array2[0]>=0 && array2[1]>= 0 && array2[0] <= array2[1] && array2[1] <= array.Length-1 && array.Length < 100)
            {
            do
            {
                for (int i = array2[0]; i < (array2[1]); i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        int m = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = m;
                    }
                }
                array2[1] = array2[1] - 1;
            }
            while (array2[1] > array2[0]);

            }
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + " ");
            }
        }
    }
}