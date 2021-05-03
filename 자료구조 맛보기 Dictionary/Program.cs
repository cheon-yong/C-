using System;
using System.Collections.Generic;

namespace 자료구조_맛보기_Dictionary
{
    class Monster
    {
        public int id;
        public Monster(int id)
        {
            this.id = id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            //해쉬테이블기반으로 작성된 Dictionary
            //해쉬테이블이란?
            //박스에서 공을 찾는다고 생각할 때
            //아주 큰 박스에서 특정 공을 찾는다고 하면 하나씩 꺼내보면서 판별하는
            //방법밖에 없음
            //그러나 여러 박스를 사용한다고 하면 (ex. 1~10, 11~20 ....)
            //훨씬 빠르게 찾을 수 있음
            //속도는 확실히 빠르나 메모리상으로는 손해를 보는 방법
            //메모리를 내주고 성능을 취하는 방식

            // Key -> Value
            // Dictionary
            // Key를 알면 value를 굉장히 빠르게 찾을 수 있음
            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();
            
            //dic.Add(1, new Monster(1));
            //dic[5] = new Monster(5);
            for (int i = 0; i < 10000; i++)
            {
                dic.Add(i, new Monster(i));
            }

            Monster mon = dic[5000];
            //만약 키가 없으면 에러가 발생
            //ex)2000000

            Monster mon2;
            bool found = dic.TryGetValue(2000, out mon2);

            //삭제
            dic.Remove(7777);
            Console.WriteLine(dic.Count);

            //초기화
            dic.Clear();

            //크기
            Console.WriteLine(dic.Count);
        }
    }
}
