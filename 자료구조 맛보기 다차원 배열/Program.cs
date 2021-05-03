using System;

namespace 자료구조_맛보기_다차원_배열
{
    class Map
    {
        int[,] tiles =
        {
            {1, 1, 1, 1, 1 },
            {1, 0, 0, 0, 1 },
            {1, 0, 0, 0, 1 },
            {1, 0, 0, 0, 1 },
            {1, 1, 1, 1, 1 }
        };

        public void Render()
        {
            ConsoleColor defalutColor = Console.ForegroundColor;

            //arr.GetLenghth(1); [1, 0] 중 1의 크기
            for (int y = 0; y < tiles.GetLength(1); y++)
            {
                //arr.GetLenghth(1); [1, 0] 중 0의 크기
                for (int x = 0; x < tiles.GetLength(0); x++)
                {
                    if (tiles[y, x] == 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\u25cf");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = defalutColor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5] { 10, 20, 30, 40, 50 };

            //[ , , ]
            //[ , , ]
            //위와 같은 형태
            //int[,] arr = new int[2, 3];
            //int[,] arr2 = new int[, ] { {1, 2, 3}, {1, 2, 3} };
            //int[,] arr3 = { { 1, 2, 3 }, { 1, 2, 3 } };

            Map map = new Map();
            map.Render();

            //가변 배열
            int[][] a = new int[3][];
            a[0] = new int[5];
            a[1] = new int[7];
            a[2] = new int[2];
        }
    }
}
