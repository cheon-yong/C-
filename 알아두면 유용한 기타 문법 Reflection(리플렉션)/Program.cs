using System;
using System.Reflection;

namespace 알아두면_유용한_기타_문법_Reflection_리플렉션_
{
    class Program
    {
        // attribute를 사용하면 주석도 참고 가능
        class Important : System.Attribute
        {
            string message;

            public Important(string message) { this.message = message; }
        }
        class Monster
        {
            // hp입니다. 중요한 정보입니다.
            [Important("Very Important")]
            public int hp;
            protected int attack;
            private float speed;

            public void Attack() { }
        }
        static void Main(string[] args)
        {
            // Reflection 이란 X-Ray 같은 것
            Monster monster = new Monster();

            Type type = monster.GetType();

            var fields = type.GetFields(System.Reflection.BindingFlags.Public 
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static
                | System.Reflection.BindingFlags.Instance);

            foreach (FieldInfo filed in fields)
            {
                string access = "protected";
                if (filed.IsPublic)
                    access = "public";
                else if (filed.IsPrivate)
                    access = "private";

                var attributes = filed.GetCustomAttributes();

                Console.WriteLine($"{access} {filed.FieldType.Name}, {filed.Name}");
            }
        }
    }
}
