using System;
using System.Linq;

namespace questionC
{
    class Program
    {
        // C - Doukasen
        static void Main(string[] args)
        {
            var N = int.Parse(System.Console.ReadLine());

            var lines = new double[N];
            var speeds = new double[N];
            var T = 0.0d;

            for (int i = 0; i < N; i++)
            {
                var qLine = System.Console.ReadLine().Split(' ');
                var A = double.Parse(qLine[0]);
                var B = double.Parse(qLine[1]);
                lines[i] = A;
                speeds[i] = B;
                // せや！前から行っても後ろから行っても、端っこにたどりつくのにかかる時間は同じなんじゃね
                T += (lines[i] / speeds[i]);
            }

            // そしたら、前から行ったときと後ろから行ったときに2つの火花が出会うのは、全体の半分の時刻なんじゃね
            var x = T / 2;

            // 半分の時刻のときにどこまでいってるか、前から順番に計算したろ
            var result = 0.0d;
            for (int i = 0; i < N; i++)
            {
                var t = lines[i] / speeds[i];
                if (x <= t) {
                    result += x * speeds[i];
                    break;
                } else {
                    x -= t;
                    result += lines[i];
                }
            }

            Console.WriteLine($"{result}");
        }
    }
}
