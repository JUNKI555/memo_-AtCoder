using System;
using System.Collections.Generic;

namespace questionC
{
    class Program
    {
        // C - Neo-lexicographic Ordering
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var X = System.Console.ReadLine();
            var N = int.Parse(System.Console.ReadLine());

            var nameList = new List<string>();
            for (int i = 0; i < N; i++)
            {
                var S = System.Console.ReadLine();
                nameList.Add(S);
            }

            var strComp = new StrComparer(X);
            nameList.Sort(strComp);

            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }

            Console.Out.Flush();
        }
    }

    public class StrComparer : IComparer<string> {
        public string Lexico;

        public StrComparer(string lexico) {
            this.Lexico = lexico;
        }

        public int Compare(string x, string y) {
            var scoreX = 0;
            var scoreY = 0;

            var loop = 0;
            if (x.Length > y.Length) {
                loop = x.Length;
                scoreX += 100;
            } else if (x.Length > y.Length) {
                loop = y.Length;
                scoreY += 100;
            } else {
                loop = x.Length;
            }

            var rank = 100;
            for (int i = 0; i < loop; i++)
            {
                scoreX += (Lexico.IndexOf(x[i]) + rank);
                scoreY += (Lexico.IndexOf(y[i]) + rank);
                rank += 100;
            }

            return scoreY - scoreX;
        }
    }
}
