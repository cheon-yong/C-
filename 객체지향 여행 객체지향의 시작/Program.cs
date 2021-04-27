using System;

namespace 객체지향_여행_객체지향의_시작
{
    //객체 (OOP Object Oriented Programming
    // TextRPG을 객체지향으로 확장

    // Knight
    // 속성 : hp, attack
    // 기능 : Move, Attack, Die

    // 참조 복사
    class Knight
    {
        public int hp;
        public int attack;

        public void Move()
        {
            Console.WriteLine("Knight Move");
         }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }

    }

    // 얕은 복사
    struct Mage
    {
        public int hp;
        public int attack;
    }
    class Program
    {
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }

        static void KillKnight(Knight knight)
        {
            knight.hp = 0 ;
        }

        // 객체는 new 키워드를 반드시 사용해야함
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 100;
           
            /*
            Mage mage;
            mage.hp = 100;
            mage.attack = 10;

            Mage mage2 = mage;
            mage2.hp = 0;

            knight.Move();
            knight.Attack();
            KillKnight(knight);
            KillMage(mage);
            */

            //아래와 같이하면 knight와 knight2는 같은 것
            //Knight knight2 = knight;
            //knight.hp = 0;

            //아래와 같은 방법들이 있음
            //Knight knight2 = new Knight();
            //knight2.hp = 200;
            //knight2.attack = 100;


            Knight knight2 = knight.Clone();

        }
    }
}
