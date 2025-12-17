 using System;
using System.Numerics;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Hello World");

        int math;
        int physics;
        int chemistry;
        Console.WriteLine("Enter marks for Math:");
        math = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter marks for Physics:");
        physics = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter marks for Chemistry:");
        chemistry = int.Parse(Console.ReadLine());
        int totalMakrs = math + physics + chemistry;
        if (math >= 65 && physics>55 && chemistry >= 50)
        {
            Console.WriteLine("The candidate is eligible for admission.");
        }
        else
        {
            Console.WriteLine("The candidate is not eligible for admission.");
        }
        Console.WriteLine(totalMakrs);


    }
}