using System;
using System.Text;

namespace questionC
{
    class Program
    {
        // Many Balls // 不正解
        static void Main(string[] args)
        {
            var N = decimal.Parse(System.Console.ReadLine());

            if (N == 1) {
                Console.WriteLine("A");
                return;
            }

            if (N == 2) {
                Console.WriteLine("AA");
                return;
            }

            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var doubleN = decimal.ToDouble(N);
            var log2N = (int)Math.Log2(doubleN);
            var powN = Math.Pow(2, log2N);
            var zan = doubleN - powN;

            var sb = new StringBuilder("AA");
            const string A = "A";
            const string B = "B";

            for (var i = 0; i < (log2N - 1); i++) {
                sb.Append(B);
            }

            for (var i = 0; i < zan; i++) {
                sb.Append(A);
            }

            Console.WriteLine(sb.ToString());

            Console.Out.Flush();
        }
    }
}
