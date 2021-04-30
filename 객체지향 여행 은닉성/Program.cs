using System;

namespace 객체지향_여행_은닉성
{
    // OOP (은닉성 / 상속성 / 다형성)
    // 프로그램이 커질 수록 코드 분석이 어렵고
    // 그럴 때 함수의 이름으로 기능을 분석
    // 위험한 기능이 있는 함수를 노출하는 것은 좋지 않음
    class Knight
    {
        //접근 한정자 public protected private (C# 은 internal 등이 더 있음) 
        // public = 모든 곳에서 접근 가능
        // private = 현재 객체에서만 접근 가능
        // protected = 현재 객체, 상속받은 클래스에서 접근 가능
        // 접근 한정자를 붙이지 않으면 기본값은 private
        private int hp;
        protected int attack;
        public void Sethp(int hp)
        {
            this.hp = hp;
        }

        private void SecretFunction()
        {
            hp = 20;
        }
    }

    class SuperKnight : Knight
    {
        void Test()
        {
            attack = 100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
