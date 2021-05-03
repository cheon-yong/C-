using System;

namespace 자료구조_맛보기_배열
{
    class Program
    {
        static void Main(string[] args)
        {
            // 배열
            // 크기와 입력한 숫자만큼 입력해야함
            //int[] scores = new int[] {10, 20, 30, 40, 50 };
            //int[] scores = { 10, 20, 30, 40, 50 };
            int[] scores = new int[5] { 10, 20, 30, 40, 50 };

            //배열은 참조타입
            //index는 0부터 시작
            //scores[0] = 10;
            //scores[1] = 20;
            //scores[2] = 30;
            //scores[3] = 40;
            //scores[4] = 50;


            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }


            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
        }
    }
}
