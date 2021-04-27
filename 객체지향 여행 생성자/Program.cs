using System;

namespace 객체지향_여행_생성자
{
    class Knight
    {
        public int hp;
        public int attack;
        public Knight()
        {
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출!");
        }

        //빈 생성자를 먼저 호출한 뒤 int 생성자를 호출하는 문법
        public Knight(int hp) : this()
        {
            this.hp = hp;
            Console.WriteLine("int 생성자 호출!");
        }

        public Knight(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
            Console.WriteLine("int, int 생성자 호출!");
        }

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }
        
        public void Move()
        {
            Console.WriteLine("knight move");
        }

        public void Attack()
        {
            Console.WriteLine("knight attack");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight(200);
            
        }

    }
}
