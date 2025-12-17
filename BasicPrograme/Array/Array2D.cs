using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Array2D
    {

        static void Main()
        {
            int[,] arr1 = {
            {1,2,3,4,5},
            {6,7,8,9,10},
            {11,12,13,14,15}
            };

            // Console.WriteLine(arr1.Length);
            //Console.WriteLine(arr1.Rank);
            //Console.WriteLine(arr1.ToString());

            // no. of rows 
            //Console.WriteLine(arr1.GetLength(0));
            // no. of column
            //Console.WriteLine(arr1.GetLength(1));


            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for(int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        Console.Write(arr1[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(arr1.GetValue(2, 4));


        }
    }
}
