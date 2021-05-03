using System;

namespace 알아두면_유용한_기타_문법_Interface_인터페이스_
{
    class Program
    {
        //abstract class(추상클래스)는 객체를 생성할 수 없음
        //추상클래스 안에 함수들은 추상함수
        abstract class Monster
        {
            public abstract void Shout();
        }

        /*
        abstract class Flyable
        {
            public abstract void Fly();
        }
        */

        interface IFlyable
        {
            void Fly();
        }

        class Orc : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("오크다!");
            }
        }

        class Skeleton : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("스켈레톤이다!");
            }
        }

        //C#은 다중상속이 불가
        //class FlyableOrc : Monster, Flyable

        class FlyableOrc : Orc, IFlyable
        {
            public void Fly()
            {

            }
        }

        static void DoFly(IFlyable flyable)
        {
            flyable.Fly();
        }
        static void Main(string[] args)
        {
            FlyableOrc orc = new FlyableOrc();
            IFlyable flyable = new FlyableOrc();
            DoFly(orc);
            DoFly(flyable);
        }
    }
}
