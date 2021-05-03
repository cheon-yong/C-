using System;

namespace 알아두면_유용한_기타_문법_Event_이벤트_
{
    class Program
    {
        static int OnInputTest(int a)
        {
            Console.WriteLine($"Input Received! {a}");
            return (a);
        }
        static void Main(string[] args)
        {
            // 대리자도 훌륭하지만 치명적인 단점이 있다.
            // 대리자객체에 접근할 수 있으면 호출도 자유롭다.
            // 그렇기 때문에 이를 보완할 방법이 Event이다

            InputManager inputManager = new InputManager();

            inputManager.InputKey += OnInputTest;
            while (true)
            {
                inputManager.Update();
            }
            // event는 강제로 호출할 수 없음
            // inputManager.InputKey(); -> 불가능
            // 이런 방식을 사용하는 것을 옵저버 패턴이라고 함
        }
    }
}
