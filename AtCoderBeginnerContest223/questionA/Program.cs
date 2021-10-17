using System;

namespace questionA
{
    class Program
    {
        // A - Exact Price
        static void Main(string[] args)
        {
            var X = int.Parse(System.Console.ReadLine());

            if (X < 100) {
                Console.WriteLine("No");
                return;
            }

            if ((X % 100) == 0) {
                Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
            }
        }
    }
}
