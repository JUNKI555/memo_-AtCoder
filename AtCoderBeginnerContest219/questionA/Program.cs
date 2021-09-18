using System;

namespace questionA
{
    class Program
    {
        // A - AtCoder Quiz 2
        static void Main(string[] args)
        {
            var X = int.Parse(System.Console.ReadLine());

            if (X < 40) {
                Console.WriteLine($"{40-X}");
            } else if ((40 <= X)&&(X < 70)) {
                Console.WriteLine($"{70-X}");
            } else if ((70 <= X)&&(X < 90)) {
                Console.WriteLine($"{90-X}");
            } else {
                Console.WriteLine("expert");
            }
        }
    }
}
