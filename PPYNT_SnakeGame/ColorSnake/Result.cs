using PPYNT_SnakeGame.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPYNT_SnakeGame.ColorSnake
{
    internal class Result
    {
        static List<int> topScore;
        public static List<int> TopScore
        {
            get { return topScore; }
        }
        static Result()
        {
            topScore = new List<int>();
        }
        public static bool addScore(int score)
        {
            if (topScore.Count == 0)
            {
                topScore.Add(score);
                return true;
            }
            foreach (int x in topScore)
            {
                if (score >= x)
                {
                    topScore.Insert(topScore.IndexOf(x), score);
                    if (topScore.Count > 5)
                    {
                        topScore.RemoveAt(topScore.Count - 1);
                    }
                    return true;
                }
            }
            return false;
        }
        public static void readFile(string filename)
        {
            if (!File.Exists(filename))
            {
                File.Create(filename);  return;
            }
            StreamReader sr = new StreamReader(filename);
            while (!sr.EndOfStream)
            {
                topScore.Add(int.Parse(sr.ReadLine().Substring(4)));
            }
            sr.Close();
        }
        public static void updateFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            int index = 1;
            sw.Flush();
            foreach (int score in topScore)
            {
                sw.WriteLine("#{0}: {1}", index++, score);
            }
            sw.Close();
        }
    }
}
