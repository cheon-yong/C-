using System;

namespace 객체지향_여행_상속성
{
    class Player // 부모클래스, 기반클래스
    {
        static public int counter = 1; // 오로지 1개만 증가

        public int id;
        public int hp;
        public int attack;

        public Player()
        {
            Console.WriteLine("Player 생성자 호출 !");
        }

        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("Player hp 호출!");
        }

        public void Move()
        {
            Console.WriteLine("player move");
        }

        public void Attack()
        {
            Console.WriteLine("player attack");
        }
    }
    class Mage : Player
    {

    }

    class Archer : Player
    {

    }
    class Knight : Player //자식 클래스 혹은 파생 클래스 
    {
        int c;
        public Knight() : base(100)
        {
            this.c = 10;
            base.hp = 100;
            Console.WriteLine("Knight 생성자 호출 !");
        }

        //static 키워드를 사용하는 함수는 객체 변수에 접근할 수 없음!
        //즉, this.id 등을 사용할 수 없고 오로지 static으로 선언된 변수만 수정 가능
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Move();
            knight.Attack();
        }

    }
}
