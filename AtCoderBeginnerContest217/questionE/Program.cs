using System;
using System.Collections.Generic;

namespace questionE
{
    class Program
    {
        // E - Sorting Queries : TLE
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var Q = int.Parse(System.Console.ReadLine());
            var set = new Queue<int>();

            for (int i = 0; i < Q; i++)
            {
                var line = System.Console.ReadLine();

                // Enqueue
                if (line.StartsWith("1")) {
                    var qLine = line.Split(' ');
                    var x = int.Parse(qLine[1]);

                    set.Enqueue(x);
                    continue;
                }

                // sort
                if (line == "3") {
                    var array = set.ToArray();
                    Array.Sort(array);
                    set = new Queue<int>(array);
                    continue;
                }

                // output and Dequeue
                var d = set.Dequeue();
                Console.WriteLine(d.ToString());
            }

            Console.Out.Flush();
        }
    }
}
