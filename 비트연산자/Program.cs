using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 비트연산자
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 1;

            // << >> &(and) |(or) ^(xor) ~(not)

            // 2진수로 표시했을 때 화살표 방향으로 이동
            // 부호는 그대로 유지되기 때문에 잘 고려해서 사용할 것
            //num = num << 1;


            // ^(xor) 연산예제
            // int id = 0; 
            // id에는 실제로 여러 정보를 가지고 있음
            // 32 비트 중 4비트는 지역 정보, 다음 4비트는 캐릭터 정보 등
            // 그렇기 때문에 or, and, xor등을 적절히 활용하여 ID를 생성
            // xor은 암호학에서도 많이 사용
            // xor은 똑같은 숫자에 같은 값을 두번 연산하면 초기값이 나옴
            //int id = 123;
            //int key = 401;

            //int a = id ^ key;
            //int b = a ^ key;

            // id값을 그대로 네트워크를 통해 보내면 해킹의 위험이 있으므로
            // key를 이용하여 암호화 한 뒤 전송
       

        }
    }
}
