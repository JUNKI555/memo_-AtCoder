using System;
using System.Text;

namespace questionB
{
    class Program
    {
        // B - Maritozzo
        static void Main(string[] args)
        {
            var S1 = System.Console.ReadLine();
            var S2 = System.Console.ReadLine();
            var S3 = System.Console.ReadLine();
            var T = System.Console.ReadLine();

            var sb = new StringBuilder();

            foreach (var value in T)
            {
                switch (value.ToString()) {
                    case "1":
                        sb.Append(S1);
                        break;
                    case "2":
                        sb.Append(S2);
                        break;
                    case "3":
                        sb.Append(S3);
                        break;
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
