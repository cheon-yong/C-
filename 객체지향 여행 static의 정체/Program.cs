using System;

namespace 객체지향_여행_static의_정체
{
    class Knight
    {
        //static을 선언하면 클래스에 종속적인 것
        //모든 객체에서 공유하는 값임
        
        static public int counter = 1; // 오로지 1개만 증가

        public int id;
        public int hp;
        public int attack;

        //빈 생성자를 먼저 호출한 뒤 int 생성자를 호출하는 문법
        public Knight()
        {
            id = counter;
            counter++;
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출!");
        }

        //static 키워드를 사용하는 함수는 객체 변수에 접근할 수 없음!
        //즉, this.id 등을 사용할 수 없고 오로지 static으로 선언된 변수만 수정 가능
        static public void Test()
        {
            counter++;
        }

        //static 키워드를 사용했다고 해서 일반 인스턴스에 접근이 불가능한 것은 아님
        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
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
            Knight knight1 = new Knight();
            Console.WriteLine(knight1.id);
            Knight knight2 = new Knight();
            Console.WriteLine(knight2.id);
            Knight knight3 = new Knight();
            Console.WriteLine(knight3.id);

            //static은 클래스(객체x) 에 종속적이기 때문에 인스턴스를 생성하지 않고
            //바로 바로 호출할 수 있음
            Knight knight = Knight.CreateKnight();
            Console.WriteLine(knight.id);

        }

    }
}

//static 키워드를 선언하면 
