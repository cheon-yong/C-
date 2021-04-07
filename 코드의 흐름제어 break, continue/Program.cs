using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드의_흐름제어_break__continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 97;
            bool isPrime = true;

            for (int i = 0; i < 10; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                Console.WriteLine("소수입니다");
            else
                Console.WriteLine("소수가 아닙니다");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                    continue;
                Console.WriteLine($"3으로 나뉘는 숫자 : {i}");
            }
        }
    }
}
