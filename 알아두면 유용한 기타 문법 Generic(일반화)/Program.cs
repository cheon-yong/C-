using System;
using System.Collections.Generic;

namespace 알아두면_유용한_기타_문법_Generic_일반화_
{
    class Program
    {

        //일반화 문법<>T는 Template의 약자.
        //인자 추가는 <T, K>와 같이 사용
        //C#에서는 조건 추가가 가능
        //class Mylist<T> where T : struct 값형식이어야한다.
        //class Mylist<T> where T : class  참조형식이어야한다.
        //class Mylist<T> where T : new()  반드시 기본생성자가 있어야한다.
        //class Mylist<T> where T : Monster  반드시 몬스터 또는 몬스터를 상속받아야한다.

        class MyList<T> 
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
        }

        class Monster
        {

        }
   
        static void Test<T> (T input)
        {
          
        }


        static void Main(string[] args)
        {
            //object라는 클래스를 사용하면
            //다양한 데이터를 저장할 수 있음
            //var라는 타입을 사용해도 되나 object와는 다른 점은
            //var는 입력되는 값을 보고 컴파일러가 추정하여
            //그에 맞게 할당

            //obj를 사용해도 되나 매번 heap영역에 할당하고
            //그것을 int 또는 string등에 할당하여 사용하는 것은
            //비효율적
            //즉 모든 타입을 obj로 저장하여 사용하는 것은 합당하지 않음

            //그렇기 때문에 일반화를 사용
            MyList<int> myIntList = new MyList<int>();
            int item = myIntList.GetItem(0);

            MyList<short> myShortList = new MyList<short>();
            MyList<Monster> myMonsterList = new MyList<Monster>();

            Test<int>(3);
        }
    }
}
