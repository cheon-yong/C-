using System;

namespace 알아두면_유용한_기타_문법_Exception_예외처리_
{
    class Program
    {
        //예외를 선언할 수 있음
        //Exception을 반드시 상속해야함
        class TestException : Exception
        {

        }
        static void Main(string[] args)
        {
            // 잘쓰이지는 않지만 네트워크 접속 등에서는 반드시 필요한 부분
            try
            {
                // 1. 0으로 나눌 때
                // 2. 잘못된 메모리를 참조하는 경우 (null, 잘못된 타입 등)
                // 3. 오버플로우
                // ...

                throw new TestException();

                /*int a = 10;
                int b = 0;
                int result = a / b;*/
            }
            //세부적인 것이 위로 와야함
            catch (DivideByZeroException e)
            {
                //여기가 실행되면
            }
            catch (Exception e)
            {
                //여기는 실행이 안됨
            }
            finally
            {
                //여기는 무조건 실행됨
            }
        }
    }
}
