using System;
using System.Collections.Generic;

namespace 자료구조_맛보기_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열을 매애애애우 크게 선언하는 방법으로
            //배열의 확장을 피할 수 있으나 메모리 낭비가 심함
            int[] arr = new int[1000];

            //List <- 동적 배열
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            //Count는 list의 크기
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

            foreach (int num in list)
                Console.WriteLine(num);

            //삽입
            //Add는 가장 마지막에 데이터를 삽입
            list.Insert(2, 999);

            Console.WriteLine("삽입");
            foreach (int num in list)
                Console.WriteLine(num);

            //삭제
            //처음 만난 값을 삭제
            //list.Remove(value);
            list.Remove(3);
            Console.WriteLine("삭제");
            foreach (int num in list)
                Console.WriteLine(num);

            //index로 삭제
            //list.RemoveAt(index);
            list.RemoveAt(0);
            Console.WriteLine("인덱스 삭제");
            foreach (int num in list)
                Console.WriteLine(num);

            //초기화
            list.Clear();
            Console.WriteLine("초기화");
            foreach (int num in list)
                Console.WriteLine(num);
            //삽입 삭제가 효율적이지는 않음.
        }
    }
}
