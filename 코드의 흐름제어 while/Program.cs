using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드의_흐름제어_while
{
    class Program
    {
        static void Main(string[] args)
        {
            // while 반복문
            int count = 5;
            while (count > 0)
            {
                Console.WriteLine("Hello World");
                count--;
            }
            string answer; 
            do
            {
                Console.WriteLine("Is that true?");
                answer = Console.ReadLine();
            } while (answer != "y");
        }
    }
}
