using System;

namespace BigSolution.HelloWorld.Application
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine($"Hello World! {string.Join(" ", args)}");
            Console.ReadKey();
        }
    }
}
