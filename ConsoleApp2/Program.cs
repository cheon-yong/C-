using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 100;
            int level = 50;

            // 사칙연산 가능 + - * / %;
            // 사칙연산 우선순위를 따르며 ()로 우선순위 지정 가능
            // hp = 2 * (100 + 1);

            // %는 나머지를 구하는 것
            // hp = 100 % 33 // = 1

            //증가 감소 연산자
            //hp++  // hp = hp + 1;
            //hp--  // hp = hp - 1;

            //++hp
            //--hp

            //둘의 차이는 연산 순서의 차이
            //hp++는 대입 후 증가, ++hp는 증가 후 대입

            // 비교연산자
            // <, <=, >, >=, !=, ==
            // 참 혹은 거짓을 반환
            //bool b = hp < 100;
            //bool b = (hp == 100);


            // 논리연산자
            // && AND , || OR  ! NOT
            bool isAlive = (hp > 0);
            bool isHighLevel = (level >= 40);

            // a = 살아있는 고렙 유저인가요?
            bool a = isAlive && isHighLevel;

            // b = 살아있거나 고렙 유저이거나 둘 중 하나 인가요?
            bool b = isAlive || isHighLevel;

            // c = 죽은 유저인가요?
            bool c = !isAlive;
            Console.WriteLine(hp);
        }
    }
}
