using System;

namespace 코드의_흐름제어_오버로딩
{
    class Program
    {
        // 함수 이름의 재사용
        static int Add(int a, int b)
        {
            Console.WriteLine("Add int 호출");
            return a + b;
        }
        static int Add(int a, int b, int c)
        {
            Console.WriteLine("Add int 호출");
            return a + b + c;
        }

        //다 입력할 것이면 순서를 지켜주어야 한다.
        //C#에서는 값을 지정하여 입력하는 것이 가능
        //ex. Add(1, 2, d:1.0f);  
        static int Add(int a, int b, int c, int d = 0)
        {
            Console.WriteLine("Add int 호출");
            return a + b + c + d;
        }

        static float Add(float a, float b)
        {
            Console.WriteLine("Add float 호출");
            return a + b;
        }
        
        //반환 형식과 전달인자의 이름은 오버로딩에 영향을 주지 않으며
        //함수의 이름, 전달인자의 수, 전달인자의 타입만 영향을 준다.
        
        static void Main(string[] args)
        {
            int ret = Add(2, 3);
            float ret2 = Add(2.0f, 3.0f);
            int ret3 = Add(2, 3, 4);
            //순서를 지킬 것
            int ret4 = Add(2, 3, 4, 5);
            Console.WriteLine(ret);
            Console.WriteLine(ret2);
            Console.WriteLine(ret3);
            Console.WriteLine(ret4);

            //
        }
    }
}
