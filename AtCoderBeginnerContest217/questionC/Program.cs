using System;
using System.Collections.Generic;

namespace questionC
{
    class Program
    {
        // C - Inverse of Permutation
        static void Main(string[] args)
        {
            var N = int.Parse(System.Console.ReadLine());
 
            var qArray = new int[N];
 
            var line = System.Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                var p = int.Parse(line[i]);
                qArray[p-1] = (i+1);
            }
 
            Console.WriteLine(string.Join(" ", qArray));
        }
    }
}
