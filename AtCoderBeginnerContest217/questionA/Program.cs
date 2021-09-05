using System;

namespace questionA
{
    class Program
    {
        // A - Lexicographic Order
        static void Main(string[] args)
        {
            var qLine = System.Console.ReadLine().Split(' ');
            var S = qLine[0];
            var T = qLine[1];
 
            if (string.Compare(S, T) < 0) {
                Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
            }
        }
    }
}
