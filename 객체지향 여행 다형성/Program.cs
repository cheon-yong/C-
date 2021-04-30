using System;

namespace 객체지향_여행_다형성
{
    //OOP (은닉성/상속성/다형성)
    class Player
    {
        protected int hp;
        protected int attack;

        public virtual void Move()
        {
            Console.WriteLine("Player 이동 !");
        }
    }
    //오버로딩은 함수이름의 재사용
    //오버라이딩은 다형성을 이용하는 것
    class Knight : Player
    {
        //sealed는 더 이상 오버라이딩을 불가능하게 한다
        public sealed override void Move()
        {
            //base.Move();
            Console.WriteLine("Knight 이동 !");
        }
    }

    class Mage : Player
    {
        public int mp;
        public override void Move()
        {
            Console.WriteLine("Mage 이동 !");
        }
    }


    class Program
    {

        static void EnterGame(Player player)
        {
            //가능하지만 비효율적인 방법
            /*
            Mage mage = (player as Mage);
            if (mage != null)
            {
                mage.mp = 10;
                mage.Move();
            }

            Knight knight = (player as Knight);
            if (knight != null)
            {
                knight.Move();
            }
            */
            player.Move();
        }
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            //knight.Move();
            //mage.Move();


            //EnterGame(knight);
            //EnterGame(mage);
        }
    }
}
