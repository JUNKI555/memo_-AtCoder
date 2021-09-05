using System;

namespace questionA
{
    class Program
    {
        // Signed Difficulty
        static void Main(string[] args)
        {
            var line = System.Console.ReadLine().Split('.');

            var X = int.Parse(line[0]);
            var Y = int.Parse(line[1]);

            if ((0 <= Y)&&(Y <= 2)) {
                Console.WriteLine($"{X}-");
                return;
            }

            if ((3 <= Y)&&(Y <= 6)) {
                Console.WriteLine($"{X}");
                return;
            }

            if ((7 <= Y)&&(Y <= 9)) {
                Console.WriteLine($"{X}+");
                return;
            }
        }
    }
}
