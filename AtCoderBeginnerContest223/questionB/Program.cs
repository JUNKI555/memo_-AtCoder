using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace questionB
{
    class Program
    {
        // B - String Shifting
        static void Main(string[] args)
        {
            var S = System.Console.ReadLine();

            var sList = new List<string>();

            var workS = S;
            sList.Add(S);
            for (int i = 0; i < (S.Length - 1); i++)
            {
                var left = workS.Substring(0, 1);
                var rest = workS.Substring(1);
                workS = rest + left;
                // Console.WriteLine($"left:{workS}");
                sList.Add(workS);
            }

            workS = S;
            for (int i = 0; i <  (S.Length - 1); i++)
            {
                var right = workS.Substring(workS.Length - 1);
                var rest = workS.Substring(0, workS.Length - 1);
                workS = right + rest;
                // Console.WriteLine($"right:{workS}");
                sList.Add(workS);
            }

            sList.Sort();

            Console.WriteLine($"{sList.First()}");
            Console.WriteLine($"{sList.Last()}");
        }
    }
}
