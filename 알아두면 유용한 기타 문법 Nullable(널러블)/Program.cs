using System;

namespace 알아두면_유용한_기타_문법_Nullable_널러블_
{
    class Program
    {
        static int Find()
        {

            return 0;
        }

        class Monster
        {
            public int Id { get; set; }
        }
        static void Main(string[] args)
        {
            // Nullable = Null + able
            int? number = null;

            //number가 null 아니면 number.Value값을 넣어주고
            //number가 null 이면 ?? 뒤에 값을 넣어준다
            int b = number ?? 0;
            Console.WriteLine(b);

            /*
            if (number != null)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }

            if (number.HasValue)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }*/

            Monster monster = null;
            
            if (monster != null)
            {
                int monsterID = monster.Id;
            }

            //몬스터라는 변수가 null이 아니면 Id를 넣고
            // null이면 null을 할당
            int? id = monster?.Id;
            
        }       
    }
}
