namespace StringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //String [] arr= { "banana", "lE", "jerrrrrry", "chry" };
            //string result = string.Join(", ", arr);
            //Console.WriteLine(result); // Output: apple, banana, cherry
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //foreach (var item in arr )
            //{
            //    Console.WriteLine(item.Length);
            //}

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item.ToUpper());
            //}

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item.ToLower());
            //}

            //Array.Sort(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //Array.Reverse(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine();


            //  int max = -1;
            //  int i;
            //  int temp=0;

            //for ( i = 0; i < arr.Length; i++)
            //  {
            //      if (arr[i].Length > max)
            //      {
            //          max = arr[i].Length;
            //          temp = i;

            //      }


            //  }

            //  Console.WriteLine("Max length is: " + max);
            //  Console.WriteLine(arr[temp]);

            //int min = 10;
            //int i;
            //int temp = 0;

            //for (i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i].Length < min)
            //    {
            //        min = arr[i].Length;
            //        temp = i;

            //    }


            //}

            //Console.WriteLine("Max length is: " + min);
            //Console.WriteLine(arr[temp]);



            string[] words = { "Apple", "Banana", "Mango" };

            for (int i = 0; i < words.Length; i++)
            {
                char[] ch = words[i].ToCharArray();
                Array.Reverse(ch);
                words[i] = new string(ch);
            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }




        }
    }
}
