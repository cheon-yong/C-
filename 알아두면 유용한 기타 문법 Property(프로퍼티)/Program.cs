using System;

namespace 알아두면_유용한_기타_문법_Property_프로퍼티_
{
    class Program
    {
        // 객체지향 -> 은닉성
        class Knight
        {
            //property는 다음과 같다
            //접근 한정자를 추가할 수도 있음
            //get, set 둘중 하나가 없어도 됨
            //value는 전달인자로 고정
            /*
            int hp;
            public int Hp
            {
                get {return hp;}
                set {hp = value;}
            }
             */

            public int Hp
            {
                get; set;
            }

            //위 property는 아래와 같다
            //int _hp;
            //public int GetHp() {return _hp;}
            //publiv void SetHp(int value) {_hp=value;}

            //초기값 설정도 가능
            //public int Hp { get; set; } = 100;
        }
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Hp = 100;
            int hp = knight.Hp;


        }
    }
}
