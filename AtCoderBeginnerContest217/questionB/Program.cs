using System;
using System.Collections.Generic;

namespace questionB
{
    class Program
    {
        // B - AtCoder Quiz
        static void Main(string[] args)
        {
            var S1 = System.Console.ReadLine();
            var S2 = System.Console.ReadLine();
            var S3 = System.Console.ReadLine();

            var list = new List<string>();

            list.Add("ABC");
            list.Add("ARC");
            list.Add("AGC");
            list.Add("AHC");

            list.Remove(S1);
            list.Remove(S2);
            list.Remove(S3);

            Console.WriteLine(list[0]);
        }
    }
}
