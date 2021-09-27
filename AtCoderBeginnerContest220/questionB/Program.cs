using System;
using System.Linq;

namespace questionB
{
    class Program
    {
        // B - Base K
        static void Main(string[] args)
        {
            var K = int.Parse(System.Console.ReadLine());

            var qLine = System.Console.ReadLine().Split(' ');
            var A = qLine[0];
            var B = qLine[1];

            Decimal intA = 0;
            Decimal intB = 0;

            intA = MyToDicimal(A, K);
            intB = MyToDicimal(B, K);

            Console.WriteLine($"{intA*intB}");
        }

        private static Decimal MyToDicimal(string s, int radix)
        {
            var pow = 0;
            Decimal result = 0;
            var reverseS = new string(s.Reverse().ToArray());
            foreach (var value in reverseS)
            {
                var intV = int.Parse(value.ToString());

                if (intV > 0) {
                    if (pow == 0) {
                        result += intV;
                    } else {
                        result += (Decimal)((Math.Pow(radix, pow))*intV);
                    }
                }

                pow++;
            }

            return result;
        }
    }
}
