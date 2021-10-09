using System;

namespace questionB
{
    class Program
    {
        // B - Failing Grade
        static void Main(string[] args)
        {
            var qLine = System.Console.ReadLine().Split(' ');
            var N = int.Parse(qLine[0]);
            var P = int.Parse(qLine[1]);

            var count = 0;
            var aLine = System.Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                var a = int.Parse(aLine[i]);
                if (a < P) {
                    count++;
                }
            }

            Console.WriteLine($"{count}");
        }
    }
}
