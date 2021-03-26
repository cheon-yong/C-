using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // 주석은 C++이랑 같음
        /* 이것도 마찬가지 */
        static void Main(string[] args)
        {
            // 데이터 갖고놀기 - 정수 형식

            // 프로그램 = 데이터 + 로직
            // 정수형 데이터는 int
            // 정수형 변수 hp를 선언
            // 숫자형 데이터타입은 byte(1바이트), short(2바이트), int(4바이트), long(8바이트) 이 있음
            // byte(0 ~ 255), short (약-3만 ~ 약3만), int(약-21억 ~ 약21억), long (굉장히 넓은 범위)
            // sbyte(-128 ~ 127), ushort(0 ~ 약6만), uint (약43억), ulong(0 ~ 엄청남)
            // 자료형을 고려하는 이유는 네트워크 통신이 필요할 경우 최대한 크기를 줄여 부하를 줄여야하기 때문
            // 대부분 int를 사용(범위, 사이즈를 대부분 만족)
            // id 계열은 long으로 선언
            // int hp;
            // hp에 숫자 100을 할당
            // hp = 100;
            // Console.WriteLine("Hello number! ! {0}", hp);



            // 데이터 갖고놀기 - 2진수, 10진수, 16진수

            // 10진수 0 ~ 9
            // 2진수 0 ~ 1 표기할 때에는 앞에 0b를 붙임 ex) 0b00 0b01 0b10
            // 16진수 0 ~ F 표기할 때에는 앞에 0x를 붙임 ex) 0x01 0x02 0x0F
            // 2진수 -> 16진수변환 2진수 숫자 4개찍 끊어서 변환하면 됨 ex) 0b10001111 -> 0x8F



            // 데이터 갖고놀기 - 정수 범위의 비밀

            // 2의 보수란 최상위 비트를 부호로 사용하는 것
            // 0b1000 0000 = -128
            // 변환법 -> 모든 숫자를 바꾼 후 +1
            // ex) 56 = 0b0011 1000, -56은 숫자를 전부 변환 후 +1
            // 즉 0b1100 0111 + 1 = 0b1100 1000 = -56
            // 다른 변수들도 마찬가지



            // 데이터 갖고 놀기 - 불리언, 소수, 문자, 문자열 형식

            // bool 은 true 또는 false만을 가짐, bool은 1byte (1bit일 때보다 연산이 빠르기 때문)
            //bool b;
            //b = true;
            //b = false;

            // 소수
            // 4byte
            //float f = 3.14f; 

            // 8byte 범위가 더 넓고 정밀함
            //double d = 3.14; 

            // 문자
            // 2byte 하나의 문자를 표현하기 위한 변수
            //char c = 'a'; 

            // 문자열
            //string str = "Hello World!";

            //Console.WriteLine(str);



            // 데이터 갖고 놀기 - 형식 변환

            // 1. 사이즈가 다른 경우
            // ex)
            //int a = 1000;
            //short b = (short)a;
            // 어떤 일이 일어날 지 모르기 때문에 늘 조심해야함 하지만 반대(short -> int)는 괜찮음

            // 2. 사이는 같지만 부호가 다를 경우
            //byte c = 255;
            //sbyte sb = (sbyte)c;
            //sbyte에서는 0xFF = 0b11111111 = -1 

            // 3. 소수
            //float f = 3.1414f;
            //double d = f;
            //예상한 값과 정확히 일치하지 않을 수 있음
        }
    }
}
