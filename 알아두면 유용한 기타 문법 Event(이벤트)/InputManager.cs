using System;
using System.Collections.Generic;
using System.Text;

namespace 알아두면_유용한_기타_문법_Event_이벤트_
{
    class InputManager
    {
        public delegate int OnInputKey(int value);
        public event OnInputKey InputKey;

        //event를 호출하고 싶으면 구독하면 됨
        //Youtube의 구독과 유사한 기능
        //사용자가 입력하는 것을 캐치하는 역할
        public void Update()
        {
            if (Console.KeyAvailable == false)
                return;

            ConsoleKeyInfo info =  Console.ReadKey();
            if (info.Key == ConsoleKey.A)
            {
                // 모두에게 알려준다!
                InputKey(100);
            }
        }
    }
}
