using System;

namespace 객체지향_여행_객체지향의_시작
{
    //객체 (OOP Object Oriented Programming
    // TextRPG을 객체지향으로 확장

    // Knight
    // 속성 : hp, attack
    // 기능 : Move, Attack, Die

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

    }
    class Program
    {

        // 객체는 new 키워드를 반드시 사용해야함
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 100;

            knight.Move();
            knight.Attack();
        }
    }
}
