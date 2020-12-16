using System;

namespace PrintName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            // userName is a string that holds the name of the user.
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}");
            Console.ReadKey();
        }
    }
}
