using System;

namespace 코드의_흐름_제어_연습문제
{
    class Program
    {
        static void gugudan (int a, int b)
        {
            for (int i = 2; i <= a; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }

        static void draw_star(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static int Factorial(int n)
        {
            if (n == 1)
                return (1);
            return (Factorial(n - 1) * n);
        }
        static void Main(string[] args)
        {
            //gugudan(9, 9);
            //draw_star(5);
            int ret = Factorial(5);
            Console.WriteLine(ret);
        }
    }
}
