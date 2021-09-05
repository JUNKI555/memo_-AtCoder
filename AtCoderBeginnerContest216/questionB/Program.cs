using System;
using System.Collections.Generic;

namespace questionB
{
    class Program
    {
        // Same Name
        static void Main(string[] args)
        {
            var nameList = new List<string>();

            var N = int.Parse(System.Console.ReadLine());
            var same = false;
            for (var i = 0; i < N; i++) {
                var name = System.Console.ReadLine();

                if (nameList.Contains(name)) {
                    same = true;
                }

                nameList.Add(name);
            }

            if (same) {
                Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
            }
        }
    }
}
