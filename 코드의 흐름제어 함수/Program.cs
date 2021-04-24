using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드의_흐름제어_함수
{
    class Program
    {
        // 메소드 함수 method function ...
        /* 
         * 한정자 반환형식 이름 (매개변수)
           {
           }
         */
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static void Addone(ref int number)
        {
            number = number + 1;
        }
        static void Main(string[] args)
        {
            // int a, int b
            // main 함수에서 a, b를 선언해도 Add 함수의 a,b와는 상관 없음
            // a의 값을 Add one 이라는 함수를 통해서 100이 증가하지 않음
            // 증가하는 것을 원하면 ref라는 키워드를 사용해야함
            int a = 100;
            HelloWorld();
            int result = Add(4, 5);
            Console.WriteLine(result);
            Addone(ref a);
            Console.WriteLine(a);
        }
    }
}
