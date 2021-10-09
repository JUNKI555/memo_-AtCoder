using System;

namespace questionA
{
    class Program
    {
        // A - Four Digits
        static void Main(string[] args)
        {
            var N = int.Parse(System.Console.ReadLine());

            Console.WriteLine($"{N:0000}");
        }
    }
}
