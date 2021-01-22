using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();

            Console.WriteLine("what is your favirate color?");
            String color = Console.ReadLine();

            Console.WriteLine("what is your dog name ?");
            string dog = Console.ReadLine();

            Console.WriteLine($"Hello Everyone, my name is {name}." +
                $" My favirate color is {color}" +
                $" and my dog name is {dog} ");
        }
    }
}
