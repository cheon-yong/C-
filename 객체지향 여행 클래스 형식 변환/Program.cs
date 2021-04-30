using System;

namespace 객체지향_여행_클래스_형식_변환
{
    // OOP (은닉성/상속성/다형성)
    class Player
    {
        protected int hp;
        protected int attack;

    }

    class Knight : Player
    {

    }

    class Mage : Player
    {
        public int mp;
    }
    class Program
    {
        //Mage를 넘겨주고 싶다면??
        //Overloading이 가능하지만 비효율적
        /*
        static void EnterGame(Knight knight)
        {

        }*/
        //아래와 같이 작성한다면 Player를 상속받은 자식클래스들을 모두 사용할 수 있지만
        //Mage가 보유한 mp는 사용할 수 없다.
        //mp를 사용하기 위해서는 형변환을 해주어야한다.
        
        static Player FindPlayerById(int id)
        {
            // 있으면 id 반환
            // 없으면 null 반환
            return null;
        }
        
        static void EnterGame(Player player)
        {
            // NULL 이란?
            // "없음"이라는 의미. 정수의 0과도 다름
            //첫번째 방법
            //bool isMage = (player is Mage);
            //두번째 방법
            Mage mage = (player as Mage);
            if (mage != null)
            {
                mage.mp = 10;
            }
            
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();
            // Mage 타입 -> Player  가능
            // Player 타입 -> Mage  불가능
            // 즉 자식클래스가 부모클래스로 변환하는건 가능
            Player magePlayer = mage;
            Mage mage2 = (Mage)magePlayer;

            EnterGame(knight);
        }
    }
}
