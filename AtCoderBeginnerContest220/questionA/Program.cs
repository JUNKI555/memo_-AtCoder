using System;

namespace questionA
{
    class Program
    {
        // A - Find Multiple
        static void Main(string[] args)
        {
            var qLine = System.Console.ReadLine().Split(' ');
            var A = int.Parse(qLine[0]);
            var B = int.Parse(qLine[1]);
            var C = int.Parse(qLine[2]);

            var ok = false;
            var result = 0;
            var continueCheck = true;
            var pow = 1;

            while (continueCheck)
            {
                 result = C * pow;
                 if ((A <= result)&&(result <= B)) {
                     ok = true;
                     continueCheck = false;
                 }

                 if (B < result) {
                     continueCheck = false;
                 }

                 pow++;
            }

            if (ok) {
                Console.WriteLine($"{result}");
            } else {
                Console.WriteLine("-1");
            }
        }
    }
}
