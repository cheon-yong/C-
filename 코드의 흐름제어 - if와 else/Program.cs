using System;

namespace 코드의_흐름제어___if와_else
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //hp가 0이면 죽었다는 의미
            int hp = 1;
            bool isDead = (hp <= 0);

            //줄바꿈은 가독성을 위해서 적절히 조절할 것
            //중괄호를 사용하면 여러 작업을 수행할 수 있음
            //중괄호 스타트 위치는 개인취향이나 집단(회사 등)에서는 정한 규정을 따를 것
            if (isDead)
            { 
                Console.WriteLine("You are dead!");
                Console.WriteLine("You are dead!");
                Console.WriteLine("You are dead!");
            }
            else
            {
                Console.WriteLine("You are Alive!");
            }*/

            /*
            int choice = 0; // 0 : 가위, 1 : 바위, 2 : 보

            if (choice == 0)
                Console.WriteLine("가위입니다.");
            else if (choice == 1)
                Console.WriteLine("바위입니다.");
            else
                Console.WriteLine("보입니다.");
            */

            int choice = 0; // 0 : 가위, 1 : 바위, 2 : 보, 3 : 치트키
            //if가 응용 범위는 훨씬 넓다.
            //그러나 switch문은 가독성이 훨씬 뛰어나다.
            switch (choice)
            {
                case 0:
                    Console.WriteLine("가위입니다.");
                    break;
                case 1:
                    Console.WriteLine("바위입니다.");
                    break;
                case 2:
                    Console.WriteLine("보입니다.");
                    break;
                case 3:
                    Console.WriteLine("치트키입니다.");
                    break;
                default:
                    Console.WriteLine("다 실패했습니다.");
                    break;
            }
            //삼항연산자
            //조건 ? 맞을때 : 틀릴 때
            int number = 25;
            bool isPair = (number%2) == 0 ? true : false;
            
        }
    }
}
