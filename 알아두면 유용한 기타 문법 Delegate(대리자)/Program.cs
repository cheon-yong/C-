using System;

namespace 알아두면_유용한_기타_문법_Delegate_대리자_
{
    class Program
    {
        // 실제상황 비유
        // 상대 업체 사장님과 통화를 하고 싶지만 그럴 수 없음
        // 업체사장 대신 비서와 연락
        // 비서에게 연락처와 용건을 남기고 거꾸로 연락을 달라고 요청

        // 어떤 버튼을 눌렀을 때의 행동을 함수로 구현했을 때
        // 함수 안에 UI에 관련된 코드와 동작에 관련된 코드를 모두 넣었을 때
        // 서로 꼬일 수 있기 때문에 분리하여 관리하는 것이 좋음
        // 수정할 수 없는 함수를 사용할 경우도 있음
        // 예를 들어  Unity버튼을 눌렀을 때의 함수를 호출할 수 있어도
        // 그 내부를 수정할 수는 없음

        // 이런식으로 함수자체를 인자로 넘겨주고
        // 함수 안에서 전달함수를 실행하는 방식을 
        // 콜백방식이라고 함


        // 대리자는 UI에서 유용하게 사용할 수 있음
        delegate int Onclicked();
        // delegate -> 형식이지만 함수 자체를 인자로 넘겨주는 형식
        // 반환은 int 입력은 void
        // Onclicked가 delegate 형식의 이름이다
        

        //이러한 함수들은 수정할 수 없게 배포되는 경우가 있음
        static void ButtonPressed(Onclicked clickedFunction)
        {
            // PlayerAttack();
            // 현실적으로 힘들 수 있음(설계적으로나, 실제적으로나)
            // 그렇기 때문에 UI와 기능은 분리하는 것이 좋음
            clickedFunction();
        }

        static int TestDelegate()
        {
            Console.WriteLine("Hello Delegate");
            return 0;
        }

        static int TestDelegate2()
        {
            Console.WriteLine("Hello Delegate2");
            return 0;
        }
        static void Main(string[] args)
        {
            //대리자
            //ButtonPressed(TestDelegate);

            Onclicked clicked = new Onclicked(TestDelegate);
            clicked += TestDelegate2;

            ButtonPressed(clicked);
        }
    }
}
