using System;

namespace 알아두면_유용한_기타_문법_Delegate_대리자_
{
    class Program
    {

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
