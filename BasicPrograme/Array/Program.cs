namespace ArrayDemo
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int[] arr = { 12, 20, 3, 40, 15, 16 };
            int[] arr2 = new int[10];


            int[,] arr1 = {
            {1,2,3,4,5},
            {6,7,8,9,10},
            {11,12,13,14,15}
            };


            //Console.WriteLine(arr2.Rank);
            //Console.WriteLine(arr1.Rank);
            //Console.WriteLine(arr.Length);


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i]+"\t");
            //}

            //Console.WriteLine();


            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        Console.Write(arr1[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //Array.Sort(arr);
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();
            //Array.Reverse(arr);
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Copy opertion");



            //Array.Copy(arr, arr2, arr.Length);
            //foreach (var item in arr2)
            //{
            //    Console.Write(item + " ");
            //}

            // it include index 2 to end
            //foreach (var item in arr[2..])
            //{
            //    Console.Write(item + " ");
            //}

            // it exclude index 2
            //foreach (var item in arr[..2])
            //{
            //    Console.Write(item + " ");
            //}

            //foreach (var item in arr[2..5])
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine(arr[^3]);
            //Console.WriteLine(arr2[^1]);

           

        }
    }
}
