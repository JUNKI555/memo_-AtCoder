using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace questionC
{
    class Program
    {
        // C - Swiss-System Tournament
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var qLine = System.Console.ReadLine().Split(' ');
            var N = int.Parse(qLine[0]);
            var M = int.Parse(qLine[1]);

            var users = new List<User>();
            for (int i = 0; i < (2*N); i++)
            {
                users.Add(new User(){ Key = i+1, Value = 0});
            }

            var answers = new string[(2*N), M];
            for (int i = 0; i < (2*N); i++)
            {
                var j = 0;
                var aLine = System.Console.ReadLine();
                foreach (var a in aLine)
                {
                    answers[i, j] = a.ToString();
                    j++;
                }
            }

            var before = string.Empty;
            var after = string.Empty;
            for (int j = 0; j < M; j++)
            {
                for (int i = 0; i < (2*N); i++)
                {
                    if (i % 2 == 0) {
                        before = answers[(users[i].Key-1), j];
                    } else {
                        after = answers[(users[i].Key-1), j];
                        var gameResult = Game(before, after);
                        switch (gameResult) {
                            case 0:
                                // Do Nothing
                                break;
                            case 1:
                                // before の勝ち
                                users[i-1].Value++;
                                break;
                            case 2:
                                // after の勝ち
                                users[i].Value++;
                                break;
                        }
                    }
                }

                users.Sort((x, y) =>
                {
                    int result = y.Value - x.Value;
                    if (result == 0) 
                        result = x.Key - y.Key;
                    return result;
                });
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}");
            }

            Console.Out.Flush();
        }

        static int Game(string before, string after) {
            // 0: 引き分け, 1: beforeの勝ち, 2: afterの勝ち
            var result = 0;

            switch (before) {
                case "G":
                    switch (after) {
                        case "G":
                            result = 0;
                            break;
                        case "C":
                            result = 1;
                            break;
                        case "P":
                            result = 2;
                            break;
                    }
                    break;
                case "C":
                    switch (after) {
                        case "G":
                            result = 2;
                            break;
                        case "C":
                            result = 0;
                            break;
                        case "P":
                            result = 1;
                            break;
                    }
                    break;
                case "P":
                    switch (after) {
                        case "G":
                            result = 1;
                            break;
                        case "C":
                            result = 2;
                            break;
                        case "P":
                            result = 0;
                            break;
                    }
                    break;
            }

            return result;
        }
    }

    public class User
    {
        public int Key { get; set; }
        public int Value { get; set; }
    }
}
