using System;

namespace 자료구조_맛보기_연습문제
{
    class Program
    {
        static int GetHighestScore(int[] scores)
        {
            if (scores == null)
                return 0;

            int res = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (res < scores[i])
                    res = scores[i];
            }

            return res;
        }
        static int GetAverageScore(int[] scores)
        {
            if (scores == null)
                return 0;

            int sum = 0;
            int res;
            for (int i = 0; i < scores.Length; i++)
                sum += scores[i];
            res = sum / scores.Length;

            return res;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            if (scores == null)
                return -1;
            for (int i = 0; i<scores.Length; i++)
            {
                if (value == scores[i])
                    return i;
            }

            return -1;
        }

        static void Sort(int[] scores)
        {
            for (int i=0; i<scores.Length; i++)
            {
                for (int j=i; j<scores.Length; j++)
                {
                    if (scores[i] > scores[j])
                    {
                        int temp = scores[i];
                        scores[i] = scores[j];
                        scores[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //0 ~ 100
            int[] scores = new int[] {40, 15, 23, 50, 70, 98};
            Console.WriteLine(GetHighestScore(scores));
            Console.WriteLine(GetAverageScore(scores));
            Console.WriteLine(GetIndexOf(scores, 23));
            Sort(scores);
            foreach (int score in scores)
                Console.Write($"{score} ");
        }
    }
}
