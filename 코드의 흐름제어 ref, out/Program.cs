using System;

namespace 코드의_흐름제어_ref__out
{
    class Program
    {
        static void Divide(int a, int b, out int result1, out int result2)
        {
            result1 = a / b;
            result2 = a % b;
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void AddOne(ref int number)
        {
            number += 1;
        }

        static int AddOne2(int number)
        {
            return number + 1;
        }
        static void Main(string[] args)
        {
            int a = 100;
            AddOne(ref a);
            Console.WriteLine(a);

            //같은 동작을 하지만 AddOne2식으로 구현하는 것이 유리
            int b = AddOne2(a);
            Console.WriteLine(b);

            //그러나 참조하는 것을 사용해야할 경우가 있음 (ex. swap)
            int num1 = 1;
            int num2 = 2;
            Swap(ref num1, ref num2);
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            int number1 = 10;
            int number2 = 3;

            int result1;
            int result2;

            Divide(number1, number2, out result1, out result2);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            //out을 사용

        }
    }
}
