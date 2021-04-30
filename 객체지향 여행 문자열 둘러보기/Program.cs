using System;

namespace 객체지향_여행_문자열_둘러보기
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Harry Potter";

            name.Contains("Harry");

            // 1. 찾기
            bool found = name.Contains("Harry");
            int index = name.IndexOf('P'); // 있으면 index 없으면 -1

            // 2. 변형
            name = name + " Junior";
            
            string lowerCaseName = name.ToLower();
            string upperCaseNmae = name.ToUpper();
            string newName = name.Replace('r', 'l'); // 문자열의 r을 l로 변환

            // 3. 분할
            string[] names = name.Split(new char[] { ' ' });
            string subName = name.Substring(5); // 5번 index부터 새로운 문자열
        }
    }
}
