using System;

namespace TextRPG_디버깅_기초
{
    class Program
    {
        // 디버깅은 많은 연습이 필요하고 
        // 프로그램을 작성할 때 꼭 필요한 것
        // 브레이크 포인트를 사용하는 것을 꼭 익혀둘 것
        // 값들을 출력해서 확인하는 방법도 있지만 비추천
        static void Print(int value)
        {
            Console.WriteLine(value);
        }
        static int AddAndPrint(int a, int b)
        {
            int ret = a + b;
            Print(ret);
            return ret;
        }
        static void Main(string[] args)
        {
            int ret = AddAndPrint(10, 20);
            ret = ret + 1;
            Console.WriteLine(ret);
        }
    }
}
