using System;
using System.Collections.Generic;
using System.Linq;

namespace questionC
{
    class Program
    {
        // C - Long Sequence
        static void Main(string[] args)
        {
            var N = int.Parse(System.Console.ReadLine());

            var listA = new List<Decimal>();
            var qLine = System.Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                listA.Add(Decimal.Parse(qLine[i]));
            }

            var X = Decimal.Parse(System.Console.ReadLine());
            var sum = listA.Sum();
            Decimal result = ((Math.Floor(X/sum))*N);
            // Console.WriteLine($"result:{result}");
            Decimal answer = Math.Floor(result/N)*sum;
            // Console.WriteLine($"answer:{answer}");

            double max = Math.Pow(10, 100);
            double checkMax = 0;
            var continueFlg = true;
            while(continueFlg) {
                checkMax++;
                if (max < checkMax) {
                    continueFlg=false;
                }

                if (X < answer) {
                    continueFlg=false;
                    continue;
                }

                foreach (var a in listA)
                {
                    result++;
                    answer += a;
                    // Console.WriteLine($"answer:{answer}");
                    if (X < answer) {
                        continueFlg=false;
                        break;
                    }
                }
            }

            Console.WriteLine($"{result}");
        }
    }
}
